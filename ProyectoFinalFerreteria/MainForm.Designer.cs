namespace ProyectoFinalFerreteria
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosMasVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.FacturacionToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.ArticulosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.articulosToolStripMenuItem1});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.VentasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.ClientesToolStripMenuItem1_Click);
            // 
            // articulosToolStripMenuItem1
            // 
            this.articulosToolStripMenuItem1.Name = "articulosToolStripMenuItem1";
            this.articulosToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.articulosToolStripMenuItem1.Text = "Articulos";
            this.articulosToolStripMenuItem1.Click += new System.EventHandler(this.ArticulosToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.clientesToolStripMenuItem2,
            this.articulosMasVendidosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas del dia";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.VentasToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes con deuda";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.ClientesToolStripMenuItem2_Click);
            // 
            // articulosMasVendidosToolStripMenuItem
            // 
            this.articulosMasVendidosToolStripMenuItem.Name = "articulosMasVendidosToolStripMenuItem";
            this.articulosMasVendidosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.articulosMasVendidosToolStripMenuItem.Text = "Articulos con poco inventario";
            this.articulosMasVendidosToolStripMenuItem.Click += new System.EventHandler(this.ArticulosMasVendidosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistema De Ventas Ferreteria Nelson";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem articulosMasVendidosToolStripMenuItem;
    }
}

