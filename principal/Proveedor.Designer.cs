namespace principal
{
    partial class Proveedor
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
            lbTitleProdutcos = new Label();
            SuspendLayout();
            // 
            // lbTitleProdutcos
            // 
            lbTitleProdutcos.AutoSize = true;
            lbTitleProdutcos.Location = new Point(180, 12);
            lbTitleProdutcos.Name = "lbTitleProdutcos";
            lbTitleProdutcos.Size = new Size(95, 15);
            lbTitleProdutcos.TabIndex = 0;
            lbTitleProdutcos.Text = "CRUD Productos";
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTitleProdutcos);
            Name = "Proveedor";
            Text = "Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitleProdutcos;
    }
}