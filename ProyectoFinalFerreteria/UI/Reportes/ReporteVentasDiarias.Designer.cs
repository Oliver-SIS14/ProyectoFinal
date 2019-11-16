namespace ProyectoFinalFerreteria.UI.Reportes
{
    partial class ReporteVentasDiarias
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
            this.VentasReporteViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VentasReporteViewer
            // 
            this.VentasReporteViewer.ActiveViewIndex = -1;
            this.VentasReporteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VentasReporteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VentasReporteViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasReporteViewer.Location = new System.Drawing.Point(0, 0);
            this.VentasReporteViewer.Name = "VentasReporteViewer";
            this.VentasReporteViewer.Size = new System.Drawing.Size(800, 450);
            this.VentasReporteViewer.TabIndex = 0;
            this.VentasReporteViewer.Load += new System.EventHandler(this.VentasReporteViewer_Load);
            // 
            // ReporteVentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentasReporteViewer);
            this.Name = "ReporteVentasDiarias";
            this.Text = "Reporte de ventas del dia";
            this.Load += new System.EventHandler(this.ReporteVentasDiarias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VentasReporteViewer;
    }
}