using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace principal
{
    public partial class creaarProveedor : Form
    {
        ProveedorControler proveedorControler = new ProveedorControler();
        
        public creaarProveedor()
        {
            InitializeComponent();
            CargarProveedor();
            dgvProveedor.CellClick += dgvProveedor_CellClick;

            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
        }

        private void dgvProveedor_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];

                // Cargar datos en los TextBox
                textNit_proveedor.Text = fila.Cells["nit_proveedor"].Value?.ToString() ?? "";
                textNombre_proveedor.Text = fila.Cells["nombre_proveedor"].Value?.ToString() ?? "";
                textDireccion_proveedor.Text = fila.Cells["direccion_proveedor"].Value?.ToString() ?? "";
                textTelefono_proveedor.Text = fila.Cells["telefono_proveedor"].Value?.ToString() ?? "";
            }
        }

        private void CargarProveedor()
        {
            List<ProveedorEntity> listaProveedor = proveedorControler.MostrarProveedor();
            dgvProveedor.Rows.Clear();

            foreach (var proveedor in listaProveedor)
            {
                dgvProveedor.Rows.Add(proveedor.Id, proveedor.nit_proveedor, proveedor.nombre_proveedor, proveedor.direccion_proveedor, proveedor.telefono_proveedor);
            }
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textNit_proveedor.Text, out int nit))
            {
                MessageBox.Show("Ingrese una cédula válida.");
                return;
            }

            string nombre = textNombre_proveedor.Text;
            string direccion = textDireccion_proveedor.Text;
            string telefono = textTelefono_proveedor.Text;

            string resultado = proveedorControler.GuardarProveedor(nit, nombre, direccion, telefono);
            MessageBox.Show(resultado);

            CargarProveedor(); // Recargar los datos en la tabla
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNit_proveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProveedorEntity proveedorActualizado = new ProveedorEntity
            {
                nit_proveedor = int.Parse(textNit_proveedor.Text),
                nombre_proveedor = textNombre_proveedor.Text,
                direccion_proveedor = textDireccion_proveedor.Text,
                telefono_proveedor = textTelefono_proveedor.Text
            };

            string resultado = proveedorControler.ActualizarProveedor(proveedorActualizado);
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarProveedor(); // Recargar la tabla para ver los cambios
            LimpiarCampos(); // Limpiar los campos después de actualizar
        }
        private void LimpiarCampos()
        {
            textNit_proveedor.Clear();
            textNombre_proveedor.Clear();
            textDireccion_proveedor.Clear();
            textTelefono_proveedor.Clear();
            dgvProveedor.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                if (!int.TryParse(dgvProveedor.SelectedRows[0].Cells["nit_proveedor"].Value?.ToString(), out int nit))
                {
                    MessageBox.Show("Error al obtener el nit del proveedor.");
                    return;
                }

                string resultado = proveedorControler.EliminarProveedor(nit);
                MessageBox.Show(resultado);

                CargarProveedor();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
            }
        }
        private void lbTitleProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
