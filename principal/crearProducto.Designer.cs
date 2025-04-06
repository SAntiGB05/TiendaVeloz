namespace principal
{
    partial class crearProducto
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
            lbTitleCliente = new Label();
            textStock_producto = new TextBox();
            textPrecio_producto = new TextBox();
            textNombre_producto = new TextBox();
            textDescripcion_producto = new TextBox();
            lbPrecio_producto = new Label();
            lbNombre_producto = new Label();
            lbStock_producto = new Label();
            lbDescripcion_producto = new Label();
            dvgProducto = new DataGridView();
            cod_Producto = new DataGridViewTextBoxColumn();
            nombre_producto = new DataGridViewTextBoxColumn();
            precio_producto = new DataGridViewTextBoxColumn();
            descripcion_producto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgProducto).BeginInit();
            SuspendLayout();
            // 
            // lbTitleCliente
            // 
            lbTitleCliente.BackColor = SystemColors.ActiveBorder;
            lbTitleCliente.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleCliente.ForeColor = SystemColors.ControlText;
            lbTitleCliente.Location = new Point(30, 9);
            lbTitleCliente.Name = "lbTitleCliente";
            lbTitleCliente.Size = new Size(594, 52);
            lbTitleCliente.TabIndex = 17;
            lbTitleCliente.Text = "CRUD Producto";
            lbTitleCliente.TextAlign = ContentAlignment.MiddleLeft;
            lbTitleCliente.Click += lbTitleCliente_Click;
            // 
            // textStock_producto
            // 
            textStock_producto.Location = new Point(500, 114);
            textStock_producto.Name = "textStock_producto";
            textStock_producto.Size = new Size(125, 27);
            textStock_producto.TabIndex = 18;
            // 
            // textPrecio_producto
            // 
            textPrecio_producto.Location = new Point(178, 117);
            textPrecio_producto.Name = "textPrecio_producto";
            textPrecio_producto.Size = new Size(125, 27);
            textPrecio_producto.TabIndex = 19;
            // 
            // textNombre_producto
            // 
            textNombre_producto.Location = new Point(178, 84);
            textNombre_producto.Name = "textNombre_producto";
            textNombre_producto.Size = new Size(125, 27);
            textNombre_producto.TabIndex = 20;
            // 
            // textDescripcion_producto
            // 
            textDescripcion_producto.Location = new Point(500, 81);
            textDescripcion_producto.Name = "textDescripcion_producto";
            textDescripcion_producto.Size = new Size(125, 27);
            textDescripcion_producto.TabIndex = 22;
            // 
            // lbPrecio_producto
            // 
            lbPrecio_producto.AutoSize = true;
            lbPrecio_producto.Location = new Point(93, 120);
            lbPrecio_producto.Name = "lbPrecio_producto";
            lbPrecio_producto.Size = new Size(50, 20);
            lbPrecio_producto.TabIndex = 24;
            lbPrecio_producto.Text = "Precio";
            // 
            // lbNombre_producto
            // 
            lbNombre_producto.AutoSize = true;
            lbNombre_producto.Location = new Point(93, 87);
            lbNombre_producto.Name = "lbNombre_producto";
            lbNombre_producto.Size = new Size(64, 20);
            lbNombre_producto.TabIndex = 25;
            lbNombre_producto.Text = "Nombre";
            // 
            // lbStock_producto
            // 
            lbStock_producto.AutoSize = true;
            lbStock_producto.Location = new Point(390, 117);
            lbStock_producto.Name = "lbStock_producto";
            lbStock_producto.Size = new Size(45, 20);
            lbStock_producto.TabIndex = 26;
            lbStock_producto.Text = "Stock";
            // 
            // lbDescripcion_producto
            // 
            lbDescripcion_producto.AutoSize = true;
            lbDescripcion_producto.Location = new Point(390, 84);
            lbDescripcion_producto.Name = "lbDescripcion_producto";
            lbDescripcion_producto.Size = new Size(87, 20);
            lbDescripcion_producto.TabIndex = 27;
            lbDescripcion_producto.Text = "Descripcion";
            // 
            // dvgProducto
            // 
            dvgProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducto.Columns.AddRange(new DataGridViewColumn[] { cod_Producto, nombre_producto, precio_producto, descripcion_producto, Stock });
            dvgProducto.Location = new Point(12, 165);
            dvgProducto.Name = "dvgProducto";
            dvgProducto.RowHeadersWidth = 51;
            dvgProducto.Size = new Size(776, 228);
            dvgProducto.TabIndex = 28;
            dvgProducto.CellContentClick += dvgProducto_CellContentClick;
            // 
            // cod_Producto
            // 
            cod_Producto.HeaderText = "Cod";
            cod_Producto.MinimumWidth = 6;
            cod_Producto.Name = "cod_Producto";
            cod_Producto.Width = 70;
            // 
            // nombre_producto
            // 
            nombre_producto.HeaderText = "Nombre";
            nombre_producto.MinimumWidth = 6;
            nombre_producto.Name = "nombre_producto";
            nombre_producto.Width = 150;
            // 
            // precio_producto
            // 
            precio_producto.HeaderText = "Precio";
            precio_producto.MinimumWidth = 6;
            precio_producto.Name = "precio_producto";
            precio_producto.Width = 125;
            // 
            // descripcion_producto
            // 
            descripcion_producto.HeaderText = "Drescripcion";
            descripcion_producto.MinimumWidth = 6;
            descripcion_producto.Name = "descripcion_producto";
            descripcion_producto.Width = 290;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 90;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(372, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(251, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 39);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(131, 399);
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
            btnAgregar.Click += btnAgregar_Click;
            // 
            // crearProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dvgProducto);
            Controls.Add(lbDescripcion_producto);
            Controls.Add(lbStock_producto);
            Controls.Add(lbNombre_producto);
            Controls.Add(lbPrecio_producto);
            Controls.Add(textDescripcion_producto);
            Controls.Add(textNombre_producto);
            Controls.Add(textPrecio_producto);
            Controls.Add(textStock_producto);
            Controls.Add(lbTitleCliente);
            Name = "crearProducto";
            Text = "crearProducto";
            ((System.ComponentModel.ISupportInitialize)dvgProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitleCliente;
        private TextBox textStock_producto;
        private TextBox textPrecio_producto;
        private TextBox textNombre_producto;
        private TextBox textDescripcion_producto;
        private Label lbPrecio_producto;
        private Label lbNombre_producto;
        private Label lbStock_producto;
        private Label lbDescripcion_producto;
        private DataGridView dvgProducto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn cod_Producto;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn precio_producto;
        private DataGridViewTextBoxColumn descripcion_producto;
        private DataGridViewTextBoxColumn Stock;
    }
}