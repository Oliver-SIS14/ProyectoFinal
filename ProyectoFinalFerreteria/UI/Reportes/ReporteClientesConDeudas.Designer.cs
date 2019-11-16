namespace ProyectoFinalFerreteria.UI.Reportes
{
    partial class ReporteClientesConDeudas
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
            this.ClientesReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClientesReportViewer
            // 
            this.ClientesReportViewer.ActiveViewIndex = -1;
            this.ClientesReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientesReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClientesReportViewer.Name = "ClientesReportViewer";
            this.ClientesReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ClientesReportViewer.TabIndex = 0;
            // 
            // ReporteClientesConDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientesReportViewer);
            this.Name = "ReporteClientesConDeudas";
            this.Text = "ReporteClientesConDeudas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClientesReportViewer;
    }
}