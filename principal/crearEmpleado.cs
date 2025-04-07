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
    public partial class crearEmpleado : Form
    {
        EmpleadoControler empleadoControler = new EmpleadoControler();
        public crearEmpleado()
        {
            InitializeComponent();
            CargarEmpleado(); // Cargar datos al abrir el formulario
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;


            // Asignar eventos a los botones
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
        }

        private void dgvEmpleado_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgvEmpleado.Rows[e.RowIndex];

                // Cargar datos en los TextBox
                textCedula_empleado.Text = fila.Cells["Cedula_empleado"].Value?.ToString() ?? "";
                textNombre_empleado.Text = fila.Cells["nombre_empleado"].Value?.ToString() ?? "";
                textTelefono_empleado.Text = fila.Cells["telefono_empleado"].Value?.ToString() ?? "";
                textRol_empleado.Text = fila.Cells["rol_empleado"].Value?.ToString() ?? "";
                textPin_acceso.Text = fila.Cells["pin_acceso"].Value?.ToString() ?? "";
            }
        }

        private void CargarEmpleado()
        {
            List<EmpleadoEntity> listaEmpleado = empleadoControler.MostrarEmpleado();
            dgvEmpleado.Rows.Clear();

            foreach (var empleado in listaEmpleado)
            {
                dgvEmpleado.Rows.Add(empleado.Id, empleado.cedula_empleado, empleado.nombre_empleado, empleado.telefono_empleado, empleado.rol_empleado, empleado.pin_acceso);
            }
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textCedula_empleado.Text, out int cedula_empleado))
            {
                MessageBox.Show("Ingrese una cédula válida.");
                return;
            }

            string nombre_empleado = textNombre_empleado.Text;
            string telefono_empleado = textTelefono_empleado.Text;
            string rol_empleado = textRol_empleado.Text;
            int pin_acceso = Convert.ToInt32(textPin_acceso.Text);

            string resultado = empleadoControler.GuardarEmpleado(cedula_empleado, nombre_empleado, telefono_empleado, rol_empleado, pin_acceso);
            MessageBox.Show(resultado);

            CargarEmpleado(); // Recargar los datos en la tabla
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCedula_empleado.Text))
            {
                MessageBox.Show("Seleccione un empleado para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmpleadoEntity empleadoActualizado = new EmpleadoEntity
            {
                cedula_empleado = int.Parse(textCedula_empleado.Text),
                nombre_empleado = textNombre_empleado.Text,
                telefono_empleado = textTelefono_empleado.Text,
                rol_empleado = textRol_empleado.Text,
                pin_acceso = Convert.ToInt32(textPin_acceso.Text)
            };

            string resultado = empleadoControler.ActualizarEmpleado(empleadoActualizado);
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarEmpleado(); // Recargar la tabla para ver los cambios
            LimpiarCampos(); // Limpiar los campos después de actualizar
        }

        private void LimpiarCampos()
        {
            textCedula_empleado.Clear();
            textNombre_empleado.Clear();
            textTelefono_empleado.Clear();
            textRol_empleado.Clear();
            textPin_acceso.Clear();
            dgvEmpleado.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                if (!int.TryParse(dgvEmpleado.SelectedRows[0].Cells["cedula_empleado"].Value?.ToString(), out int cedula_empleado))
                {
                    MessageBox.Show("Error al obtener el id del empleado.");
                    return;
                }

                string resultado = empleadoControler.EliminarEmpleado(cedula_empleado);
                MessageBox.Show(resultado);

                CargarEmpleado();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
            }
        }

        private void lbTitleEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
