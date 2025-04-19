namespace principal
{
    partial class creaarProveedor
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
            lbTitleProveedor = new Label();
            lbnit_proveedor = new Label();
            lbNombre_proveedor = new Label();
            lbDireccion_proveedor = new Label();
            lbTelefono_proveedor = new Label();
            textNit_proveedor = new TextBox();
            textNombre_proveedor = new TextBox();
            textDireccion_proveedor = new TextBox();
            textTelefono_proveedor = new TextBox();
            dgvProveedor = new DataGridView();
            cod_proveedor = new DataGridViewTextBoxColumn();
            nit_proveedor = new DataGridViewTextBoxColumn();
            nombre_proveedor = new DataGridViewTextBoxColumn();
            direccion_proveedor = new DataGridViewTextBoxColumn();
            telefono_proveedor = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // lbTitleProveedor
            // 
            lbTitleProveedor.BackColor = SystemColors.ActiveBorder;
            lbTitleProveedor.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleProveedor.ForeColor = SystemColors.ControlText;
            lbTitleProveedor.Location = new Point(12, 9);
            lbTitleProveedor.Name = "lbTitleProveedor";
            lbTitleProveedor.Size = new Size(594, 52);
            lbTitleProveedor.TabIndex = 17;
            lbTitleProveedor.Text = "Tabla Proveedor";
            lbTitleProveedor.TextAlign = ContentAlignment.MiddleLeft;
            lbTitleProveedor.Click += lbTitleProveedor_Click;
            // 
            // lbnit_proveedor
            // 
            lbnit_proveedor.AutoSize = true;
            lbnit_proveedor.Location = new Point(161, 80);
            lbnit_proveedor.Name = "lbnit_proveedor";
            lbnit_proveedor.Size = new Size(32, 20);
            lbnit_proveedor.TabIndex = 18;
            lbnit_proveedor.Text = "Nit:";
            // 
            // lbNombre_proveedor
            // 
            lbNombre_proveedor.AutoSize = true;
            lbNombre_proveedor.Location = new Point(126, 119);
            lbNombre_proveedor.Name = "lbNombre_proveedor";
            lbNombre_proveedor.Size = new Size(67, 20);
            lbNombre_proveedor.TabIndex = 19;
            lbNombre_proveedor.Text = "Nombre:";
            // 
            // lbDireccion_proveedor
            // 
            lbDireccion_proveedor.AutoSize = true;
            lbDireccion_proveedor.Location = new Point(400, 84);
            lbDireccion_proveedor.Name = "lbDireccion_proveedor";
            lbDireccion_proveedor.Size = new Size(75, 20);
            lbDireccion_proveedor.TabIndex = 20;
            lbDireccion_proveedor.Text = "Direccion:";
            // 
            // lbTelefono_proveedor
            // 
            lbTelefono_proveedor.AutoSize = true;
            lbTelefono_proveedor.Location = new Point(400, 123);
            lbTelefono_proveedor.Name = "lbTelefono_proveedor";
            lbTelefono_proveedor.Size = new Size(70, 20);
            lbTelefono_proveedor.TabIndex = 21;
            lbTelefono_proveedor.Text = "Telefono:";
            // 
            // textNit_proveedor
            // 
            textNit_proveedor.Location = new Point(196, 77);
            textNit_proveedor.Name = "textNit_proveedor";
            textNit_proveedor.Size = new Size(125, 27);
            textNit_proveedor.TabIndex = 22;
            // 
            // textNombre_proveedor
            // 
            textNombre_proveedor.Location = new Point(196, 116);
            textNombre_proveedor.Name = "textNombre_proveedor";
            textNombre_proveedor.Size = new Size(125, 27);
            textNombre_proveedor.TabIndex = 23;
            // 
            // textDireccion_proveedor
            // 
            textDireccion_proveedor.Location = new Point(481, 77);
            textDireccion_proveedor.Name = "textDireccion_proveedor";
            textDireccion_proveedor.Size = new Size(125, 27);
            textDireccion_proveedor.TabIndex = 24;
            // 
            // textTelefono_proveedor
            // 
            textTelefono_proveedor.Location = new Point(481, 116);
            textTelefono_proveedor.Name = "textTelefono_proveedor";
            textTelefono_proveedor.Size = new Size(125, 27);
            textTelefono_proveedor.TabIndex = 25;
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { cod_proveedor, nit_proveedor, nombre_proveedor, direccion_proveedor, telefono_proveedor });
            dgvProveedor.Location = new Point(12, 149);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(776, 244);
            dgvProveedor.TabIndex = 26;
            // 
            // cod_proveedor
            // 
            cod_proveedor.HeaderText = "Cod";
            cod_proveedor.MinimumWidth = 6;
            cod_proveedor.Name = "cod_proveedor";
            cod_proveedor.Width = 80;
            // 
            // nit_proveedor
            // 
            nit_proveedor.HeaderText = "Nit";
            nit_proveedor.MinimumWidth = 6;
            nit_proveedor.Name = "nit_proveedor";
            nit_proveedor.Width = 80;
            // 
            // nombre_proveedor
            // 
            nombre_proveedor.HeaderText = "Nombre";
            nombre_proveedor.MinimumWidth = 6;
            nombre_proveedor.Name = "nombre_proveedor";
            nombre_proveedor.Width = 200;
            // 
            // direccion_proveedor
            // 
            direccion_proveedor.HeaderText = "Direccion";
            direccion_proveedor.MinimumWidth = 6;
            direccion_proveedor.Name = "direccion_proveedor";
            direccion_proveedor.Width = 200;
            // 
            // telefono_proveedor
            // 
            telefono_proveedor.HeaderText = "Telefono";
            telefono_proveedor.MinimumWidth = 6;
            telefono_proveedor.Name = "telefono_proveedor";
            telefono_proveedor.Width = 160;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(373, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(252, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 39);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(132, 399);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(91, 39);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 39);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // creaarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProveedor);
            Controls.Add(textTelefono_proveedor);
            Controls.Add(textDireccion_proveedor);
            Controls.Add(textNombre_proveedor);
            Controls.Add(textNit_proveedor);
            Controls.Add(lbTelefono_proveedor);
            Controls.Add(lbDireccion_proveedor);
            Controls.Add(lbNombre_proveedor);
            Controls.Add(lbnit_proveedor);
            Controls.Add(lbTitleProveedor);
            Name = "creaarProveedor";
            Text = "creaarProveedor";
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitleProveedor;
        private Label lbnit_proveedor;
        private Label lbNombre_proveedor;
        private Label lbDireccion_proveedor;
        private Label lbTelefono_proveedor;
        private TextBox textNit_proveedor;
        private TextBox textNombre_proveedor;
        private TextBox textDireccion_proveedor;
        private TextBox textTelefono_proveedor;
        private DataGridView dgvProveedor;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn cod_proveedor;
        private DataGridViewTextBoxColumn nit_proveedor;
        private DataGridViewTextBoxColumn nombre_proveedor;
        private DataGridViewTextBoxColumn direccion_proveedor;
        private DataGridViewTextBoxColumn telefono_proveedor;
    }
}