namespace ProyectoFinalFerreteria.UI.Registros
{
    partial class RegistroCobro
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
            this.IDClienteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.LimiteCreditoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDClienteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(140, 12);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(138, 20);
            this.IDNumericUpDown.TabIndex = 0;
            // 
            // IDClienteNumericUpDown
            // 
            this.IDClienteNumericUpDown.Location = new System.Drawing.Point(140, 92);
            this.IDClienteNumericUpDown.Name = "IDClienteNumericUpDown";
            this.IDClienteNumericUpDown.Size = new System.Drawing.Size(276, 20);
            this.IDClienteNumericUpDown.TabIndex = 1;
            this.IDClienteNumericUpDown.ValueChanged += new System.EventHandler(this.IDClienteNumericUpDown_ValueChanged);
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(140, 144);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(276, 20);
            this.DepositoTextBox.TabIndex = 2;
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(140, 170);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(276, 20);
            this.BalanceTextBox.TabIndex = 3;
            this.BalanceTextBox.TextChanged += new System.EventHandler(this.BalanceTextBox_TextChanged);
            // 
            // LimiteCreditoTextBox
            // 
            this.LimiteCreditoTextBox.Location = new System.Drawing.Point(140, 196);
            this.LimiteCreditoTextBox.Name = "LimiteCreditoTextBox";
            this.LimiteCreditoTextBox.Size = new System.Drawing.Size(276, 20);
            this.LimiteCreditoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CobroId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ClienteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deposito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LimiteDeCredito";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(157, 308);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(194, 20);
            this.UsuarioTextBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Usuario";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(140, 39);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FechaDateTimePicker.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fecha";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_google_web_search_241;
            this.BuscarButton.Location = new System.Drawing.Point(285, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(132, 54);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.borradoricon1;
            this.EliminarButton.Location = new System.Drawing.Point(296, 239);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(120, 63);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.GuardarIcon__1_1;
            this.GuardarButton.Location = new System.Drawing.Point(157, 239);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(120, 63);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.NuevoIcon__1_1;
            this.NuevoButton.Location = new System.Drawing.Point(16, 239);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(120, 63);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(140, 118);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.ReadOnly = true;
            this.ClienteTextBox.Size = new System.Drawing.Size(276, 20);
            this.ClienteTextBox.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nombre";
            // 
            // RegistroCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimiteCreditoTextBox);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.IDClienteNumericUpDown);
            this.Controls.Add(this.IDNumericUpDown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistroCobro";
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.RegistroCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDClienteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.NumericUpDown IDClienteNumericUpDown;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox LimiteCreditoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label8;
    }
}