namespace ProyectoFinalFerreteria.UI.Registros
{
    partial class RegistroArticulos
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
            this.components = new System.ComponentModel.Container();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ArticuloTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InventarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.UnidadComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNumericUpDown.Location = new System.Drawing.Point(77, 17);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(149, 20);
            this.IDNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.BuscarIcon__1_;
            this.BuscarButton.Location = new System.Drawing.Point(332, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(129, 45);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulo";
            // 
            // ArticuloTextBox
            // 
            this.ArticuloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticuloTextBox.Location = new System.Drawing.Point(77, 95);
            this.ArticuloTextBox.Name = "ArticuloTextBox";
            this.ArticuloTextBox.Size = new System.Drawing.Size(384, 20);
            this.ArticuloTextBox.TabIndex = 4;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.NuevoIcon__1_;
            this.NuevoButton.Location = new System.Drawing.Point(12, 244);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(129, 61);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.GuardarIcon__1_;
            this.GuardarButton.Location = new System.Drawing.Point(174, 244);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(129, 61);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.borradoricon;
            this.EliminarButton.Location = new System.Drawing.Point(332, 244);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(129, 61);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo";
            // 
            // CodigoMaskedTextBox
            // 
            this.CodigoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoMaskedTextBox.Location = new System.Drawing.Point(77, 69);
            this.CodigoMaskedTextBox.Mask = "0000";
            this.CodigoMaskedTextBox.Name = "CodigoMaskedTextBox";
            this.CodigoMaskedTextBox.Size = new System.Drawing.Size(384, 20);
            this.CodigoMaskedTextBox.TabIndex = 13;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaTextBox.Location = new System.Drawing.Point(77, 121);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(384, 20);
            this.MarcaTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inventario";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(77, 176);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(384, 20);
            this.PrecioNumericUpDown.TabIndex = 20;
            // 
            // InventarioNumericUpDown
            // 
            this.InventarioNumericUpDown.Location = new System.Drawing.Point(77, 202);
            this.InventarioNumericUpDown.Name = "InventarioNumericUpDown";
            this.InventarioNumericUpDown.Size = new System.Drawing.Size(384, 20);
            this.InventarioNumericUpDown.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Unidad";
            // 
            // UnidadComboBox
            // 
            this.UnidadComboBox.FormattingEnabled = true;
            this.UnidadComboBox.Location = new System.Drawing.Point(77, 149);
            this.UnidadComboBox.Name = "UnidadComboBox";
            this.UnidadComboBox.Size = new System.Drawing.Size(383, 21);
            this.UnidadComboBox.TabIndex = 23;
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(475, 317);
            this.Controls.Add(this.UnidadComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InventarioNumericUpDown);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.CodigoMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ArticuloTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNumericUpDown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistroArticulos";
            this.Text = "Registro (Articulos)";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArticuloTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox CodigoMaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.NumericUpDown InventarioNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UnidadComboBox;
        private System.Windows.Forms.Label label7;
    }
}