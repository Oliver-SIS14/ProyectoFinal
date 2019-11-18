namespace ProyectoFinalFerreteria.UI.Reportes
{
    partial class ReporteImprimirFactura
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
            this.FacturaReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FacturaReportViewer
            // 
            this.FacturaReportViewer.ActiveViewIndex = -1;
            this.FacturaReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacturaReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacturaReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturaReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturaReportViewer.Name = "FacturaReportViewer";
            this.FacturaReportViewer.Size = new System.Drawing.Size(800, 450);
            this.FacturaReportViewer.TabIndex = 0;
            this.FacturaReportViewer.Load += new System.EventHandler(this.FacturaReportViewer_Load);
            // 
            // ReporteImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FacturaReportViewer);
            this.Name = "ReporteImprimirFactura";
            this.Text = "ReporteImprimirFactura";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FacturaReportViewer;
    }
}