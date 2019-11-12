namespace ProyectoFinalFerreteria.UI.Consultas
{
    partial class ConsultaProducto
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
            this.ProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoDataGridView
            // 
            this.ProductoDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDataGridView.Location = new System.Drawing.Point(16, 60);
            this.ProductoDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductoDataGridView.Name = "ProductoDataGridView";
            this.ProductoDataGridView.Size = new System.Drawing.Size(1035, 445);
            this.ProductoDataGridView.TabIndex = 1;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Enabled = false;
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(153, 30);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(128, 21);
            this.HastaDateTimePicker.TabIndex = 6;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Enabled = false;
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(16, 30);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(128, 21);
            this.DesdeDateTimePicker.TabIndex = 7;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Monto",
            "Cliente",
            "CodigoCliente",
            "IdCliente"});
            this.FiltroComboBox.Location = new System.Drawing.Point(291, 29);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(217, 23);
            this.FiltroComboBox.TabIndex = 8;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(517, 29);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(329, 21);
            this.CriterioTextBox.TabIndex = 9;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Location = new System.Drawing.Point(856, 27);
            this.ConsultarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(195, 27);
            this.ConsultarButton.TabIndex = 10;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Criterio";
            // 
            // ConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.ProductoDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsultaProducto";
            this.Text = "Consulta (Articulos)";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductoDataGridView;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}