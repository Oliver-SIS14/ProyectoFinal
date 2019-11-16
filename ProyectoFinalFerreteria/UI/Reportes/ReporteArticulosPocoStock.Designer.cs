namespace ProyectoFinalFerreteria.UI.Reportes
{
    partial class ReporteArticulosPocoStock
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
            this.ArticulosReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ArticulosReportViewer
            // 
            this.ArticulosReportViewer.ActiveViewIndex = -1;
            this.ArticulosReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArticulosReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArticulosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticulosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ArticulosReportViewer.Name = "ArticulosReportViewer";
            this.ArticulosReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ArticulosReportViewer.TabIndex = 0;
            // 
            // ReporteArticulosPocoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArticulosReportViewer);
            this.Name = "ReporteArticulosPocoStock";
            this.Text = "ReporteArticulosPocoStock";
            this.Load += new System.EventHandler(this.ReporteArticulosPocoStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ArticulosReportViewer;
    }
}