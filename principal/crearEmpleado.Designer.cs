namespace principal
{
    partial class crearEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitleEmpleado = new Label();
            lbCedula_empleado = new Label();
            lbNombre_empleado = new Label();
            lbTelefono_empleado = new Label();
            lbPin_acceso = new Label();
            lbRol_empleado = new Label();
            textPin_acceso = new TextBox();
            textTelefono_empleado = new TextBox();
            textRol_empleado = new TextBox();
            textNombre_empleado = new TextBox();
            textCedula_empleado = new TextBox();
            dgvEmpleado = new DataGridView();
            id_empleado = new DataGridViewTextBoxColumn();
            cedula_empleado = new DataGridViewTextBoxColumn();
            nombre_empleado = new DataGridViewTextBoxColumn();
            telefono_empleado = new DataGridViewTextBoxColumn();
            rol_empleado = new DataGridViewTextBoxColumn();
            pin_acceso = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // lbTitleEmpleado
            // 
            lbTitleEmpleado.BackColor = SystemColors.ActiveBorder;
            lbTitleEmpleado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleEmpleado.ForeColor = SystemColors.ControlText;
            lbTitleEmpleado.Location = new Point(24, 19);
            lbTitleEmpleado.Name = "lbTitleEmpleado";
            lbTitleEmpleado.Size = new Size(594, 52);
            lbTitleEmpleado.TabIndex = 17;
            lbTitleEmpleado.Text = "Gestion Empleado";
            lbTitleEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            lbTitleEmpleado.Click += lbTitleEmpleado_Click;
            // 
            // lbCedula_empleado
            // 
            lbCedula_empleado.AutoSize = true;
            lbCedula_empleado.Location = new Point(72, 90);
            lbCedula_empleado.Name = "lbCedula_empleado";
            lbCedula_empleado.Size = new Size(55, 20);
            lbCedula_empleado.TabIndex = 18;
            lbCedula_empleado.Text = "Cedula";
            // 
            // lbNombre_empleado
            // 
            lbNombre_empleado.AutoSize = true;
            lbNombre_empleado.Location = new Point(63, 123);
            lbNombre_empleado.Name = "lbNombre_empleado";
            lbNombre_empleado.Size = new Size(64, 20);
            lbNombre_empleado.TabIndex = 19;
            lbNombre_empleado.Text = "Nombre";
            // 
            // lbTelefono_empleado
            // 
            lbTelefono_empleado.AutoSize = true;
            lbTelefono_empleado.Location = new Point(60, 156);
            lbTelefono_empleado.Name = "lbTelefono_empleado";
            lbTelefono_empleado.Size = new Size(67, 20);
            lbTelefono_empleado.TabIndex = 20;
            lbTelefono_empleado.Text = "Telefono";
            // 
            // lbPin_acceso
            // 
            lbPin_acceso.AutoSize = true;
            lbPin_acceso.Location = new Point(391, 123);
            lbPin_acceso.Name = "lbPin_acceso";
            lbPin_acceso.Size = new Size(80, 20);
            lbPin_acceso.TabIndex = 21;
            lbPin_acceso.Text = "Pin Acceso";
            // 
            // lbRol_empleado
            // 
            lbRol_empleado.AutoSize = true;
            lbRol_empleado.Location = new Point(368, 90);
            lbRol_empleado.Name = "lbRol_empleado";
            lbRol_empleado.Size = new Size(103, 20);
            lbRol_empleado.TabIndex = 22;
            lbRol_empleado.Text = "Rol Empleado";
            // 
            // textPin_acceso
            // 
            textPin_acceso.Location = new Point(477, 120);
            textPin_acceso.Name = "textPin_acceso";
            textPin_acceso.Size = new Size(141, 27);
            textPin_acceso.TabIndex = 23;
            // 
            // textTelefono_empleado
            // 
            textTelefono_empleado.Location = new Point(133, 153);
            textTelefono_empleado.Name = "textTelefono_empleado";
            textTelefono_empleado.Size = new Size(138, 27);
            textTelefono_empleado.TabIndex = 24;
            // 
            // textRol_empleado
            // 
            textRol_empleado.Location = new Point(477, 87);
            textRol_empleado.Name = "textRol_empleado";
            textRol_empleado.Size = new Size(141, 27);
            textRol_empleado.TabIndex = 25;
            // 
            // textNombre_empleado
            // 
            textNombre_empleado.Location = new Point(133, 120);
            textNombre_empleado.Name = "textNombre_empleado";
            textNombre_empleado.Size = new Size(138, 27);
            textNombre_empleado.TabIndex = 26;
            // 
            // textCedula_empleado
            // 
            textCedula_empleado.Location = new Point(133, 87);
            textCedula_empleado.Name = "textCedula_empleado";
            textCedula_empleado.Size = new Size(138, 27);
            textCedula_empleado.TabIndex = 27;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { id_empleado, cedula_empleado, nombre_empleado, telefono_empleado, rol_empleado, pin_acceso });
            dgvEmpleado.Location = new Point(12, 193);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.RowHeadersWidth = 51;
            dgvEmpleado.Size = new Size(776, 200);
            dgvEmpleado.TabIndex = 28;
            // 
            // id_empleado
            // 
            id_empleado.HeaderText = "ID";
            id_empleado.MinimumWidth = 6;
            id_empleado.Name = "id_empleado";
            id_empleado.Width = 80;
            // 
            // cedula_empleado
            // 
            cedula_empleado.HeaderText = "Cedula";
            cedula_empleado.MinimumWidth = 6;
            cedula_empleado.Name = "cedula_empleado";
            cedula_empleado.Width = 125;
            // 
            // nombre_empleado
            // 
            nombre_empleado.HeaderText = "Nombre";
            nombre_empleado.MinimumWidth = 6;
            nombre_empleado.Name = "nombre_empleado";
            nombre_empleado.Width = 140;
            // 
            // telefono_empleado
            // 
            telefono_empleado.HeaderText = "Telefono";
            telefono_empleado.MinimumWidth = 6;
            telefono_empleado.Name = "telefono_empleado";
            telefono_empleado.Width = 125;
            // 
            // rol_empleado
            // 
            rol_empleado.HeaderText = "Rol";
            rol_empleado.MinimumWidth = 6;
            rol_empleado.Name = "rol_empleado";
            rol_empleado.Width = 125;
            // 
            // pin_acceso
            // 
            pin_acceso.HeaderText = "Pin";
            pin_acceso.MinimumWidth = 6;
            pin_acceso.Name = "pin_acceso";
            pin_acceso.Width = 125;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(373, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(252, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 39);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(132, 399);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(91, 39);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 39);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // crearEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvEmpleado);
            Controls.Add(textCedula_empleado);
            Controls.Add(textNombre_empleado);
            Controls.Add(textRol_empleado);
            Controls.Add(textTelefono_empleado);
            Controls.Add(textPin_acceso);
            Controls.Add(lbRol_empleado);
            Controls.Add(lbPin_acceso);
            Controls.Add(lbTelefono_empleado);
            Controls.Add(lbNombre_empleado);
            Controls.Add(lbCedula_empleado);
            Controls.Add(lbTitleEmpleado);
            Name = "crearEmpleado";
            Text = "crearEmpleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitleEmpleado;
        private Label lbCedula_empleado;
        private Label lbNombre_empleado;
        private Label lbTelefono_empleado;
        private Label lbPin_acceso;
        private Label lbRol_empleado;
        private TextBox textPin_acceso;
        private TextBox textTelefono_empleado;
        private TextBox textRol_empleado;
        private TextBox textNombre_empleado;
        private TextBox textCedula_empleado;
        private DataGridView dgvEmpleado;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn id_empleado;
        private DataGridViewTextBoxColumn cedula_empleado;
        private DataGridViewTextBoxColumn nombre_empleado;
        private DataGridViewTextBoxColumn telefono_empleado;
        private DataGridViewTextBoxColumn rol_empleado;
        private DataGridViewTextBoxColumn pin_acceso;
    }
}