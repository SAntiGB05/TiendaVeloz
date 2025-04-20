namespace principal
{
    partial class crearFactura
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
            TbFactura = new TabControl();
            TpCliente = new TabPage();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblTotal = new Label();
            btnEliminarFila = new Button();
            btnAgregarFila = new Button();
            label4 = new Label();
            label3 = new Label();
            cbCliente = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvDetalles = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio_unitario = new DataGridViewTextBoxColumn();
            precio_total = new DataGridViewTextBoxColumn();
            lblFecha = new DateTimePicker();
            TpProveedor = new TabPage();
            lbNumFac = new Label();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbtotal1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dateTimePicker2 = new DateTimePicker();
            lbProveedor = new Label();
            lbtittle = new Label();
            TbFactura.SuspendLayout();
            TpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            TpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // TbFactura
            // 
            TbFactura.Controls.Add(TpCliente);
            TbFactura.Controls.Add(TpProveedor);
            TbFactura.Location = new Point(8, 32);
            TbFactura.Name = "TbFactura";
            TbFactura.SelectedIndex = 0;
            TbFactura.Size = new Size(890, 503);
            TbFactura.TabIndex = 3;
            // 
            // TpCliente
            // 
            TpCliente.Controls.Add(btnEliminar);
            TpCliente.Controls.Add(btnAgregar);
            TpCliente.Controls.Add(lblTotal);
            TpCliente.Controls.Add(btnEliminarFila);
            TpCliente.Controls.Add(btnAgregarFila);
            TpCliente.Controls.Add(label4);
            TpCliente.Controls.Add(label3);
            TpCliente.Controls.Add(cbCliente);
            TpCliente.Controls.Add(label2);
            TpCliente.Controls.Add(label1);
            TpCliente.Controls.Add(dgvDetalles);
            TpCliente.Controls.Add(lblFecha);
            TpCliente.Location = new Point(4, 29);
            TpCliente.Name = "TpCliente";
            TpCliente.Padding = new Padding(3);
            TpCliente.Size = new Size(882, 470);
            TpCliente.TabIndex = 0;
            TpCliente.Text = "Cliente";
            TpCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(155, 418);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 39);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 418);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 39);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar Factura";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(18, 389);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(73, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:  $";
            // 
            // btnEliminarFila
            // 
            btnEliminarFila.Location = new Point(699, 244);
            btnEliminarFila.Name = "btnEliminarFila";
            btnEliminarFila.Size = new Size(172, 81);
            btnEliminarFila.TabIndex = 10;
            btnEliminarFila.Text = "Eliminar Fila";
            btnEliminarFila.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFila
            // 
            btnAgregarFila.Location = new Point(699, 147);
            btnAgregarFila.Name = "btnAgregarFila";
            btnAgregarFila.Size = new Size(172, 81);
            btnAgregarFila.TabIndex = 9;
            btnAgregarFila.Text = "Agregar Fila";
            btnAgregarFila.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 75);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "N° Factura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 75);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(321, 69);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(115, 28);
            cbCliente.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 17);
            label1.Name = "label1";
            label1.Size = new Size(174, 38);
            label1.TabIndex = 4;
            label1.Text = "Tabla Cliente";
            // 
            // dgvDetalles
            // 
            dgvDetalles.BackgroundColor = SystemColors.AppWorkspace;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { producto, cantidad, precio_unitario, precio_total });
            dgvDetalles.Location = new Point(15, 117);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(678, 248);
            dgvDetalles.TabIndex = 3;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.Width = 200;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // precio_unitario
            // 
            precio_unitario.HeaderText = "Precio Unitario";
            precio_unitario.MinimumWidth = 6;
            precio_unitario.Name = "precio_unitario";
            precio_unitario.Width = 150;
            // 
            // precio_total
            // 
            precio_total.HeaderText = "Precio_Total";
            precio_total.MinimumWidth = 6;
            precio_total.Name = "precio_total";
            precio_total.Width = 150;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(518, 71);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(254, 27);
            lblFecha.TabIndex = 2;
            // 
            // TpProveedor
            // 
            TpProveedor.Controls.Add(lbNumFac);
            TpProveedor.Controls.Add(label11);
            TpProveedor.Controls.Add(button1);
            TpProveedor.Controls.Add(button2);
            TpProveedor.Controls.Add(lbtotal1);
            TpProveedor.Controls.Add(button3);
            TpProveedor.Controls.Add(button4);
            TpProveedor.Controls.Add(label8);
            TpProveedor.Controls.Add(label9);
            TpProveedor.Controls.Add(comboBox2);
            TpProveedor.Controls.Add(label10);
            TpProveedor.Controls.Add(dataGridView2);
            TpProveedor.Controls.Add(dateTimePicker2);
            TpProveedor.Controls.Add(lbProveedor);
            TpProveedor.Location = new Point(4, 29);
            TpProveedor.Name = "TpProveedor";
            TpProveedor.Padding = new Padding(3);
            TpProveedor.Size = new Size(882, 470);
            TpProveedor.TabIndex = 1;
            TpProveedor.Text = "Proveedor";
            TpProveedor.UseVisualStyleBackColor = true;
            // 
            // lbNumFac
            // 
            lbNumFac.AutoSize = true;
            lbNumFac.Location = new Point(179, 75);
            lbNumFac.Name = "lbNumFac";
            lbNumFac.Size = new Size(51, 20);
            lbNumFac.TabIndex = 49;
            lbNumFac.Text = "N° Fac";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(179, 76);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 48;
            // 
            // button1
            // 
            button1.Location = new Point(153, 418);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 46;
            button1.Text = "Eliminar Factura";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 418);
            button2.Name = "button2";
            button2.Size = new Size(134, 39);
            button2.TabIndex = 45;
            button2.Text = "Agregar Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbtotal1
            // 
            lbtotal1.AutoSize = true;
            lbtotal1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtotal1.Location = new Point(16, 389);
            lbtotal1.Name = "lbtotal1";
            lbtotal1.Size = new Size(73, 25);
            lbtotal1.TabIndex = 44;
            lbtotal1.Text = "Total:  $";
            // 
            // button3
            // 
            button3.Location = new Point(697, 244);
            button3.Name = "button3";
            button3.Size = new Size(172, 81);
            button3.TabIndex = 43;
            button3.Text = "Eliminar Fila";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(697, 147);
            button4.Name = "button4";
            button4.Size = new Size(172, 81);
            button4.TabIndex = 42;
            button4.Text = "Agregar Fila";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 75);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 41;
            label8.Text = "N° Factura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 75);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 40;
            label9.Text = "Cliente:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(319, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 28);
            comboBox2.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(452, 75);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 38;
            label10.Text = "Fecha:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(13, 117);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(678, 248);
            dataGridView2.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio_Total";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(516, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.BackColor = Color.Silver;
            lbProveedor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProveedor.Location = new Point(336, 16);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(215, 38);
            lbProveedor.TabIndex = 2;
            lbProveedor.Text = "Tabla Proveedor";
            // 
            // lbtittle
            // 
            lbtittle.AutoSize = true;
            lbtittle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtittle.Location = new Point(345, 9);
            lbtittle.Name = "lbtittle";
            lbtittle.Size = new Size(215, 28);
            lbtittle.TabIndex = 2;
            lbtittle.Text = "LA TIENDA MAS VELOZ";
            lbtittle.Click += lbtittle_Click;
            // 
            // crearFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 540);
            Controls.Add(TbFactura);
            Controls.Add(lbtittle);
            Name = "crearFactura";
            Text = "crearFactura";
            TbFactura.ResumeLayout(false);
            TpCliente.ResumeLayout(false);
            TpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            TpProveedor.ResumeLayout(false);
            TpProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TbFactura;
        private TabPage TpCliente;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblTotal;
        private Button btnEliminarFila;
        private Button btnAgregarFila;
        private Label label4;
        private Label label3;
        private ComboBox cbCliente;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio_unitario;
        private DataGridViewTextBoxColumn precio_total;
        private DateTimePicker lblFecha;
        private TabPage TpProveedor;
        private Label lbNumFac;
        private Label label11;
        private Button button1;
        private Button button2;
        private Label lbtotal1;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DateTimePicker dateTimePicker2;
        private Label lbProveedor;
        private Label lbtittle;
    }
}