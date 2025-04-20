using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using Modelo.Entities;

namespace principal
{
    public partial class crearFactura : Form
    {
        private BaseDatos db = new BaseDatos();
        private List<DetalleFacturaClienteEntity> detallesCliente = new List<DetalleFacturaClienteEntity>();
        private List<DetalleFacturaProveedorEntity> detallesProveedor = new List<DetalleFacturaProveedorEntity>();
        private decimal totalFactura = 0;
        private bool esFacturaCliente = true;

        public crearFactura()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            CargarDatosIniciales();
        }

        private void ConfigurarInterfaz()
        {
            // Configurar eventos de pestañas
            TbFactura.SelectedIndexChanged += (s, e) => {
                esFacturaCliente = (TbFactura.SelectedIndex == 0);
                ActualizarInterfazSegunTipo();
            };

            // Configurar DataGridViews
            ConfigurarDataGrid(dgvDetalles);
            ConfigurarDataGrid(dataGridView2);

            // Configurar eventos de botones
            btnAgregarFila.Click += (s, e) => AgregarFilaProducto(true);
            btnEliminarFila.Click += (s, e) => EliminarFilaProducto(true);
            button4.Click += (s, e) => AgregarFilaProducto(false);
            button3.Click += (s, e) => EliminarFilaProducto(false);

            btnAgregar.Click += (s, e) => GuardarFactura();
            button2.Click += (s, e) => GuardarFactura();

            // Configurar eventos de cálculo
            dgvDetalles.CellEndEdit += (s, e) => CalcularPrecioTotalFila(true, e);
            dataGridView2.CellEndEdit += (s, e) => CalcularPrecioTotalFila(false, e);
        }

        private void ConfigurarDataGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;

            // Configurar columnas según el tipo de DataGridView
            if (dgv == dgvDetalles)
            {
                dgv.Columns.Add("producto", "Producto");
                dgv.Columns.Add("cantidad", "Cantidad");
                dgv.Columns.Add("precio_unitario", "Precio Unitario");
                dgv.Columns.Add("precio_total", "Precio Total");
                dgv.Columns["precio_total"].ReadOnly = true;
            }
            else // dataGridView2
            {
                dgv.Columns.Add("dataGridViewTextBoxColumn1", "Producto");
                dgv.Columns.Add("dataGridViewTextBoxColumn2", "Cantidad");
                dgv.Columns.Add("dataGridViewTextBoxColumn3", "Precio Unitario");
                dgv.Columns.Add("dataGridViewTextBoxColumn4", "Precio Total");
                dgv.Columns["dataGridViewTextBoxColumn4"].ReadOnly = true;
            }
        }

        private void ActualizarInterfazSegunTipo()
        {
            label1.Visible = esFacturaCliente;
            lbProveedor.Visible = !esFacturaCliente;

            // Actualizar etiquetas según el tipo de factura
            label3.Text = esFacturaCliente ? "Cliente:" : "Proveedor:";
            label9.Text = esFacturaCliente ? "Cliente:" : "Proveedor:";
        }

        private void CargarDatosIniciales()
        {
            // Cargar combos de clientes y proveedores
            cbCliente.DataSource = db.MostrarClientes();
            cbCliente.DisplayMember = "nombre_cliente";
            cbCliente.ValueMember = "Id";

            comboBox2.DataSource = db.MostrarProveedor();
            comboBox2.DisplayMember = "nombre_proveedor";
            comboBox2.ValueMember = "Id";

            // Configurar fechas
            lblFecha.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            // Configurar números de factura
            lbNumFac.Text = "Nuevo";
            label4.Text = "Nuevo";
        }

        private void AgregarFilaProducto(bool esCliente)
        {
            var dgv = esCliente ? dgvDetalles : dataGridView2;
            dgv.Rows.Add();
        }

        private void EliminarFilaProducto(bool esCliente)
        {
            var dgv = esCliente ? dgvDetalles : dataGridView2;
            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                CalcularTotal(esCliente);
            }
        }

        private void CalcularPrecioTotalFila(bool esCliente, DataGridViewCellEventArgs e)
        {
            var dgv = esCliente ? dgvDetalles : dataGridView2;
            var colCantidad = esCliente ? "cantidad" : "dataGridViewTextBoxColumn2";
            var colPrecio = esCliente ? "precio_unitario" : "dataGridViewTextBoxColumn3";
            var colTotal = esCliente ? "precio_total" : "dataGridViewTextBoxColumn4";

            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                var row = dgv.Rows[e.RowIndex];
                if (row.Cells[colCantidad].Value != null && row.Cells[colPrecio].Value != null)
                {
                    int cantidad = Convert.ToInt32(row.Cells[colCantidad].Value);
                    decimal precio = Convert.ToDecimal(row.Cells[colPrecio].Value);
                    row.Cells[colTotal].Value = cantidad * precio;
                    CalcularTotal(esCliente);
                }
            }
        }

        private void CalcularTotal(bool esCliente)
        {
            var dgv = esCliente ? dgvDetalles : dataGridView2;
            var colTotal = esCliente ? "precio_total" : "dataGridViewTextBoxColumn4";
            var lbl = esCliente ? lblTotal : lbtotal1;

            decimal total = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[colTotal].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[colTotal].Value);
                }
            }
            lbl.Text = $"Total: ${total:N2}";
            totalFactura = total;
        }

        private void GuardarFactura()
        {
            if (ValidarDatos())
            {
                try
                {
                    RecogerDetallesFactura();

                    if (esFacturaCliente)
                    {
                        GuardarFacturaCliente();
                    }
                    else
                    {
                        GuardarFacturaProveedor();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecogerDetallesFactura()
        {
            detallesCliente.Clear();
            detallesProveedor.Clear();

            var dgv = esFacturaCliente ? dgvDetalles : dataGridView2;
            var colProducto = esFacturaCliente ? "producto" : "dataGridViewTextBoxColumn1";
            var colCantidad = esFacturaCliente ? "cantidad" : "dataGridViewTextBoxColumn2";
            var colPrecio = esFacturaCliente ? "precio_unitario" : "dataGridViewTextBoxColumn3";
            var colTotal = esFacturaCliente ? "precio_total" : "dataGridViewTextBoxColumn4";

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[colProducto].Value != null && row.Cells[colCantidad].Value != null)
                {
                    if (esFacturaCliente)
                    {
                        detallesCliente.Add(new DetalleFacturaClienteEntity
                        {
                            FKcod_producto = Convert.ToInt32(row.Cells[colProducto].Value),
                            cantidad = Convert.ToInt32(row.Cells[colCantidad].Value),
                            precio_unitario = Convert.ToDecimal(row.Cells[colPrecio].Value),
                            precio_total = Convert.ToDecimal(row.Cells[colTotal].Value)
                        });
                    }
                    else
                    {
                        detallesProveedor.Add(new DetalleFacturaProveedorEntity
                        {
                            FKcod_producto = Convert.ToInt32(row.Cells[colProducto].Value),
                            cantidad = Convert.ToInt32(row.Cells[colCantidad].Value),
                            precio_unitario = Convert.ToDecimal(row.Cells[colPrecio].Value),
                            precio_total = Convert.ToDecimal(row.Cells[colTotal].Value)
                        });
                    }
                }
            }
        }

        private void GuardarFacturaCliente()
        {
            int idFactura = db.GuardarFacturaClienteConDetalles(
                (int)cbCliente.SelectedValue,
                1, // ID empleado (debería ser dinámico)
                lblFecha.Value,
                detallesCliente
            );

            MostrarResultadoOperacion(idFactura, "cliente");
        }

        private void GuardarFacturaProveedor()
        {
            int idFactura = db.GuardarFacturaProveedorConDetalles(
                (int)comboBox2.SelectedValue,
                dateTimePicker2.Value,
                detallesProveedor
            );

            MostrarResultadoOperacion(idFactura, "proveedor");
        }

        private void MostrarResultadoOperacion(int idFactura, string tipo)
        {
            if (idFactura > 0)
            {
                MessageBox.Show($"Factura de {tipo} #{idFactura} guardada!", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show($"Error al guardar factura de {tipo}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            var dgv = esFacturaCliente ? dgvDetalles : dataGridView2;
            var cb = esFacturaCliente ? cbCliente : comboBox2;
            var colProducto = esFacturaCliente ? "producto" : "dataGridViewTextBoxColumn1";
            var colCantidad = esFacturaCliente ? "cantidad" : "dataGridViewTextBoxColumn2";
            var colPrecio = esFacturaCliente ? "precio_unitario" : "dataGridViewTextBoxColumn3";

            if (cb.SelectedIndex == -1)
            {
                MessageBox.Show($"Seleccione un {(esFacturaCliente ? "cliente" : "proveedor")}",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[colProducto].Value == null ||
                    row.Cells[colCantidad].Value == null ||
                    row.Cells[colPrecio].Value == null)
                {
                    MessageBox.Show("Complete todos los campos de los productos", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (Convert.ToInt32(row.Cells[colCantidad].Value) <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            if (esFacturaCliente)
            {
                dgvDetalles.Rows.Clear();
                cbCliente.SelectedIndex = 0;
                lblTotal.Text = "Total: $0.00";
                detallesCliente.Clear();
            }
            else
            {
                dataGridView2.Rows.Clear();
                comboBox2.SelectedIndex = 0;
                lbtotal1.Text = "Total: $0.00";
                detallesProveedor.Clear();
            }
            totalFactura = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminar factura no implementada",
                          "Información",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminar factura no implementada",
                          "Información",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void lbtittle_Click(object sender, EventArgs e)
        {
            // Evento del título
        }
    }
}