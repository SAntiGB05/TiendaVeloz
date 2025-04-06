using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace principal
{
    public partial class crearCliente : Form
    {
        ClienteControler clienteControler = new ClienteControler(); // Instancia del controlador

        public crearCliente()
        {
            InitializeComponent();
            CargarClientes(); // Cargar datos al abrir el formulario
            dgvCliente.CellClick += dgvCliente_CellClick;


            // Asignar eventos a los botones
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
        }
        private void dgvCliente_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgvCliente.Rows[e.RowIndex];

                // Cargar datos en los TextBox
                textcedula.Text = fila.Cells["Cedula_nit_cliente"].Value?.ToString() ?? "";
                textNombre.Text = fila.Cells["nombre_cliente"].Value?.ToString() ?? "";
                textTelefono.Text = fila.Cells["telefono_cliente"].Value?.ToString() ?? "";
            }
        }

        private void CargarClientes()
        {
            List<ClienteEntity> listaClientes = clienteControler.MostrarClientes();
            dgvCliente.Rows.Clear();

            foreach (var cliente in listaClientes)
            {
                dgvCliente.Rows.Add(cliente.Id, cliente.cedula_nit_cliente, cliente.nombre_cliente, cliente.telefono_cliente);
            }
        }


        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textcedula.Text, out int cedula))
            {
                MessageBox.Show("Ingrese una cédula válida.");
                return;
            }

            string nombre = textNombre.Text;
            string telefono = textTelefono.Text;

            string resultado = clienteControler.GuardarCliente(cedula, nombre, telefono);
            MessageBox.Show(resultado);

            CargarClientes(); // Recargar los datos en la tabla
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textcedula.Text))
            {
                MessageBox.Show("Seleccione un cliente para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteEntity clienteActualizado = new ClienteEntity
            {
                cedula_nit_cliente = int.Parse(textcedula.Text),
                nombre_cliente = textNombre.Text,
                telefono_cliente = textTelefono.Text
            };

            string resultado = clienteControler.ActualizarCliente(clienteActualizado);
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarClientes(); // Recargar la tabla para ver los cambios
            LimpiarCampos(); // Limpiar los campos después de actualizar
        }

        private void LimpiarCampos()
        {
            textcedula.Clear();
            textNombre.Clear();
            textTelefono.Clear();
            dgvCliente.ClearSelection();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                if (!int.TryParse(dgvCliente.SelectedRows[0].Cells["Cedula_nit_cliente"].Value?.ToString(), out int cedula))
                {
                    MessageBox.Show("Error al obtener la cédula del cliente.");
                    return;
                }

                string resultado = clienteControler.EliminarCliente(cedula);
                MessageBox.Show(resultado);

                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbTitleCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
