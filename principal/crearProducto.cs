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
    public partial class crearProducto : Form
    {
        ProductoControler productoControler = new ProductoControler();
        public crearProducto()
        {
            InitializeComponent();
            CargarProducto();
            dvgProducto.CellClick += dgvProducto_CellClick;

            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
        }

        private void dgvProducto_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dvgProducto.Rows[e.RowIndex];

                // Cargar datos en los TextBox
                textNombre_producto.Text = fila.Cells["nombre_producto"].Value?.ToString() ?? "";
                textPrecio_producto.Text = fila.Cells["precio_producto"].Value?.ToString() ?? "";
                textDescripcion_producto.Text = fila.Cells["descripcion_producto"].Value?.ToString() ?? "";
                textStock_producto.Text = fila.Cells["stock"].Value?.ToString() ?? "";
            }
        }

        private void CargarProducto()
        {
            List<ProductoEntity> listaProductos = productoControler.MostrarProductos();
            dvgProducto.Rows.Clear();

            foreach (var producto in listaProductos)
            {
                dvgProducto.Rows.Add(producto.cod_productos, producto.nombre_producto, producto.precio_producto, producto.descripcion_producto, producto.stock);
            }
        }

        private bool isAdding = false; // Variable de control a nivel de clase

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isAdding) return; // Si ya está en proceso, salir

            isAdding = true; // Marcar que comenzó el proceso
            btnAgregar.Enabled = false; // Deshabilitar el botón

            try
            {
                string nombre_producto = textNombre_producto.Text;
                int precio_producto = Convert.ToInt32(textPrecio_producto.Text);
                string descripcion_producto = textDescripcion_producto.Text;
                int stock = Convert.ToInt32(textStock_producto.Text);

                string resultado = await Task.Run(() =>
                    productoControler.GuardarProducto(nombre_producto, precio_producto, descripcion_producto, stock));

                MessageBox.Show(resultado);
                CargarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                isAdding = false; // Restaurar estado
                btnAgregar.Enabled = true; // Habilitar el botón nuevamente
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para actualizar", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cod_producto = Convert.ToInt32(dvgProducto.SelectedRows[0].Cells["cod_producto"].Value);

                
                string nombre_producto = textNombre_producto.Text;
                int precio_producto = Convert.ToInt32(textPrecio_producto.Text);
                string descripcion_producto = textDescripcion_producto.Text;
                int stock = Convert.ToInt32(textStock_producto.Text);

                ProductoEntity productoActualizado = new ProductoEntity
                {
                    cod_productos = cod_producto,
                    nombre_producto = nombre_producto,
                    precio_producto = precio_producto,
                    descripcion_producto = descripcion_producto,
                    stock = stock
                };
                string resultado = productoControler.ActualizarProducto(productoActualizado);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProducto(); // Recargar la tabla para ver los cambios
                LimpiarCampos(); // Limpiar los campos después de actualizar
            
        }

        private void LimpiarCampos()
        {
            textNombre_producto.Clear();
            textPrecio_producto.Clear();
            textDescripcion_producto.Clear();
            textStock_producto.Clear();
            dvgProducto.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProducto.SelectedRows.Count > 0)
            {
                if (!int.TryParse(dvgProducto.SelectedRows[0].Cells["cod_producto"].Value?.ToString(), out int cod_producto))
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }
                string resultado = productoControler.EliminarProducto(cod_producto);
                MessageBox.Show(resultado);

                CargarProducto(); // Recargar los datos en la tabla
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombre_producto.Clear();
            textPrecio_producto.Clear();
            textDescripcion_producto.Clear();
            textStock_producto.Clear();
        }


        private void lbTitleCliente_Click(object sender, EventArgs e)
        {

        }

        private void dvgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
