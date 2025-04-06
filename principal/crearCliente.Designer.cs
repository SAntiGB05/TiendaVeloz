namespace principal
{
    partial class crearCliente
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
            Label title_clientes;
            label1 = new Label();
            textNombre = new TextBox();
            lbNombre = new Label();
            lbCedula = new Label();
            textcedula = new TextBox();
            lbTelefono = new Label();
            textTelefono = new TextBox();
            dgvCliente = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            Cedula_nit_cliente = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            telefono_cliente = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lbTitleCliente = new Label();
            title_clientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // title_clientes
            // 
            title_clientes.Location = new Point(0, 9);
            title_clientes.Name = "title_clientes";
            title_clientes.Size = new Size(100, 23);
            title_clientes.TabIndex = 14;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 15;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(436, 109);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(115, 27);
            textNombre.TabIndex = 2;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(355, 112);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(75, 20);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre :";
            // 
            // lbCedula
            // 
            lbCedula.AutoSize = true;
            lbCedula.Location = new Point(54, 112);
            lbCedula.Name = "lbCedula";
            lbCedula.Size = new Size(101, 20);
            lbCedula.TabIndex = 4;
            lbCedula.Text = "Cedula / Nit :";
            // 
            // textcedula
            // 
            textcedula.Location = new Point(161, 112);
            textcedula.Multiline = true;
            textcedula.Name = "textcedula";
            textcedula.Size = new Size(114, 23);
            textcedula.TabIndex = 5;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(352, 153);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(78, 20);
            lbTelefono.TabIndex = 6;
            lbTelefono.Text = "Telefono :";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(436, 150);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(115, 27);
            textTelefono.TabIndex = 13;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { id_cliente, Cedula_nit_cliente, nombre_cliente, telefono_cliente });
            dgvCliente.Location = new Point(25, 214);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(639, 163);
            dgvCliente.TabIndex = 8;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "id";
            id_cliente.MinimumWidth = 6;
            id_cliente.Name = "id_cliente";
            id_cliente.Width = 130;
            // 
            // Cedula_nit_cliente
            // 
            Cedula_nit_cliente.HeaderText = "Cedula / nit";
            Cedula_nit_cliente.MinimumWidth = 6;
            Cedula_nit_cliente.Name = "Cedula_nit_cliente";
            Cedula_nit_cliente.Width = 140;
            // 
            // nombre_cliente
            // 
            nombre_cliente.HeaderText = "Nombre";
            nombre_cliente.MinimumWidth = 6;
            nombre_cliente.Name = "nombre_cliente";
            nombre_cliente.Width = 140;
            // 
            // telefono_cliente
            // 
            telefono_cliente.HeaderText = "Telefono";
            telefono_cliente.MinimumWidth = 6;
            telefono_cliente.Name = "telefono_cliente";
            telefono_cliente.Width = 140;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 39);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(161, 399);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(91, 39);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(281, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 39);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(402, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbTitleCliente
            // 
            lbTitleCliente.BackColor = SystemColors.ActiveBorder;
            lbTitleCliente.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleCliente.ForeColor = SystemColors.ControlText;
            lbTitleCliente.Location = new Point(25, 32);
            lbTitleCliente.Name = "lbTitleCliente";
            lbTitleCliente.Size = new Size(594, 52);
            lbTitleCliente.TabIndex = 16;
            lbTitleCliente.Text = "CRUD Cliente";
            lbTitleCliente.TextAlign = ContentAlignment.MiddleLeft;
            lbTitleCliente.Click += lbTitleCliente_Click;
            // 
            // crearCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(lbTitleCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCliente);
            Controls.Add(textTelefono);
            Controls.Add(lbTelefono);
            Controls.Add(textcedula);
            Controls.Add(lbCedula);
            Controls.Add(lbNombre);
            Controls.Add(textNombre);
            Controls.Add(title_clientes);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "crearCliente";
            Text = "crearCliente";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label title_clientes;
        private TextBox textNombre;
        private Label lbNombre;
        private Label lbCedula;
        private TextBox textcedula;
        private Label lbTelefono;
        private TextBox textTelefono;
        private DataGridView dgvCliente;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lbTitleCliente;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn Cedula_nit_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn telefono_cliente;
    }
}