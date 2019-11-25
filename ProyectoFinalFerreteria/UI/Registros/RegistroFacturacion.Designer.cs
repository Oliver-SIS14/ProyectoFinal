namespace ProyectoFinalFerreteria.UI.Registros
{
    partial class RegistroFacturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.ArticulosGroupBox = new System.Windows.Forms.GroupBox();
            this.UnidadTextBox = new System.Windows.Forms.TextBox();
            this.PrecioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.AgregarAlGridButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ArticuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarArticuloButton = new System.Windows.Forms.Button();
            this.DescripcionComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalGeneralTextBox = new System.Windows.Forms.TextBox();
            this.ITBISTextBox = new System.Windows.Forms.TextBox();
            this.DescuentosTextBox = new System.Windows.Forms.TextBox();
            this.CantidadArticulosTextBox = new System.Windows.Forms.TextBox();
            this.TipoFacturaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.AgregarClienteButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComentariosRichTextBox = new System.Windows.Forms.RichTextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            this.ArticulosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(35, 11);
            this.IDNumericUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(82, 20);
            this.IDNumericUpDown.TabIndex = 2;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(715, 12);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.FechaDateTimePicker.TabIndex = 4;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(66, 50);
            this.ClienteComboBox.MaxDropDownItems = 100;
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(196, 21);
            this.ClienteComboBox.TabIndex = 23;
            this.ClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.ClienteComboBox_SelectedIndexChanged);
            this.ClienteComboBox.SelectedValueChanged += new System.EventHandler(this.ClienteComboBox_SelectedValueChanged);
            // 
            // ArticulosGroupBox
            // 
            this.ArticulosGroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ArticulosGroupBox.Controls.Add(this.UnidadTextBox);
            this.ArticulosGroupBox.Controls.Add(this.PrecioUnitarioTextBox);
            this.ArticulosGroupBox.Controls.Add(this.AgregarAlGridButton);
            this.ArticulosGroupBox.Controls.Add(this.RemoverButton);
            this.ArticulosGroupBox.Controls.Add(this.DetalleDataGridView);
            this.ArticulosGroupBox.Controls.Add(this.ImporteTextBox);
            this.ArticulosGroupBox.Controls.Add(this.CantidadNumericUpDown);
            this.ArticulosGroupBox.Controls.Add(this.BuscarArticuloButton);
            this.ArticulosGroupBox.Controls.Add(this.DescripcionComboBox);
            this.ArticulosGroupBox.Controls.Add(this.label13);
            this.ArticulosGroupBox.Controls.Add(this.label12);
            this.ArticulosGroupBox.Controls.Add(this.label11);
            this.ArticulosGroupBox.Controls.Add(this.label10);
            this.ArticulosGroupBox.Controls.Add(this.label9);
            this.ArticulosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticulosGroupBox.Location = new System.Drawing.Point(12, 115);
            this.ArticulosGroupBox.Name = "ArticulosGroupBox";
            this.ArticulosGroupBox.Size = new System.Drawing.Size(816, 325);
            this.ArticulosGroupBox.TabIndex = 6;
            this.ArticulosGroupBox.TabStop = false;
            this.ArticulosGroupBox.Text = "Artículos";
            // 
            // UnidadTextBox
            // 
            this.UnidadTextBox.Location = new System.Drawing.Point(415, 44);
            this.UnidadTextBox.Name = "UnidadTextBox";
            this.UnidadTextBox.ReadOnly = true;
            this.UnidadTextBox.Size = new System.Drawing.Size(100, 21);
            this.UnidadTextBox.TabIndex = 22;
            // 
            // PrecioUnitarioTextBox
            // 
            this.PrecioUnitarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioTextBox.Location = new System.Drawing.Point(526, 45);
            this.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox";
            this.PrecioUnitarioTextBox.ReadOnly = true;
            this.PrecioUnitarioTextBox.Size = new System.Drawing.Size(88, 20);
            this.PrecioUnitarioTextBox.TabIndex = 21;
            // 
            // AgregarAlGridButton
            // 
            this.AgregarAlGridButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_más_26;
            this.AgregarAlGridButton.Location = new System.Drawing.Point(756, 42);
            this.AgregarAlGridButton.Name = "AgregarAlGridButton";
            this.AgregarAlGridButton.Size = new System.Drawing.Size(52, 25);
            this.AgregarAlGridButton.TabIndex = 20;
            this.AgregarAlGridButton.UseVisualStyleBackColor = true;
            this.AgregarAlGridButton.Click += new System.EventHandler(this.AgregarAlGridButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverButton.Location = new System.Drawing.Point(678, 299);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(132, 21);
            this.RemoverButton.TabIndex = 19;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloId,
            this.Descripcion,
            this.Cantidad,
            this.Unidad,
            this.Precio,
            this.Importe});
            this.DetalleDataGridView.Location = new System.Drawing.Point(9, 72);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DetalleDataGridView.Size = new System.Drawing.Size(799, 221);
            this.DetalleDataGridView.TabIndex = 18;
            // 
            // ArticuloId
            // 
            this.ArticuloId.HeaderText = "ArticuloId";
            this.ArticuloId.Name = "ArticuloId";
            this.ArticuloId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTextBox.Location = new System.Drawing.Point(632, 45);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(109, 20);
            this.ImporteTextBox.TabIndex = 17;
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(307, 45);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(92, 20);
            this.CantidadNumericUpDown.TabIndex = 14;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // BuscarArticuloButton
            // 
            this.BuscarArticuloButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_más_26;
            this.BuscarArticuloButton.Location = new System.Drawing.Point(256, 42);
            this.BuscarArticuloButton.Name = "BuscarArticuloButton";
            this.BuscarArticuloButton.Size = new System.Drawing.Size(41, 25);
            this.BuscarArticuloButton.TabIndex = 11;
            this.BuscarArticuloButton.UseVisualStyleBackColor = true;
            this.BuscarArticuloButton.Click += new System.EventHandler(this.BuscarArticuloButton_Click);
            // 
            // DescripcionComboBox
            // 
            this.DescripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescripcionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionComboBox.FormattingEnabled = true;
            this.DescripcionComboBox.Location = new System.Drawing.Point(9, 44);
            this.DescripcionComboBox.Name = "DescripcionComboBox";
            this.DescripcionComboBox.Size = new System.Drawing.Size(241, 21);
            this.DescripcionComboBox.TabIndex = 10;
            this.DescripcionComboBox.SelectedValueChanged += new System.EventHandler(this.DescripcionComboBox_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(304, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Unidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(523, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Precio Unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(629, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Importe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "SubTotal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 449);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Total General";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "ITBIS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 478);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Descuentos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(581, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Cantidad";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(108, 446);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(177, 21);
            this.SubTotalTextBox.TabIndex = 14;
            // 
            // TotalGeneralTextBox
            // 
            this.TotalGeneralTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGeneralTextBox.Location = new System.Drawing.Point(408, 446);
            this.TotalGeneralTextBox.Name = "TotalGeneralTextBox";
            this.TotalGeneralTextBox.ReadOnly = true;
            this.TotalGeneralTextBox.Size = new System.Drawing.Size(151, 21);
            this.TotalGeneralTextBox.TabIndex = 15;
            // 
            // ITBISTextBox
            // 
            this.ITBISTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITBISTextBox.Location = new System.Drawing.Point(108, 500);
            this.ITBISTextBox.Name = "ITBISTextBox";
            this.ITBISTextBox.ReadOnly = true;
            this.ITBISTextBox.Size = new System.Drawing.Size(177, 21);
            this.ITBISTextBox.TabIndex = 16;
            // 
            // DescuentosTextBox
            // 
            this.DescuentosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentosTextBox.Location = new System.Drawing.Point(108, 473);
            this.DescuentosTextBox.Name = "DescuentosTextBox";
            this.DescuentosTextBox.Size = new System.Drawing.Size(177, 21);
            this.DescuentosTextBox.TabIndex = 17;
            this.DescuentosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentosTextBox_KeyPress);
            // 
            // CantidadArticulosTextBox
            // 
            this.CantidadArticulosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadArticulosTextBox.Location = new System.Drawing.Point(644, 446);
            this.CantidadArticulosTextBox.Name = "CantidadArticulosTextBox";
            this.CantidadArticulosTextBox.ReadOnly = true;
            this.CantidadArticulosTextBox.Size = new System.Drawing.Size(184, 20);
            this.CantidadArticulosTextBox.TabIndex = 18;
            // 
            // TipoFacturaComboBox
            // 
            this.TipoFacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFacturaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoFacturaComboBox.FormattingEnabled = true;
            this.TipoFacturaComboBox.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.TipoFacturaComboBox.Location = new System.Drawing.Point(565, 13);
            this.TipoFacturaComboBox.Name = "TipoFacturaComboBox";
            this.TipoFacturaComboBox.Size = new System.Drawing.Size(89, 21);
            this.TipoFacturaComboBox.TabIndex = 24;
            this.TipoFacturaComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFacturaComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo Factura";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyErrorProvider.SetIconAlignment(this.LogoPictureBox, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.LogoPictureBox.Image = global::ProyectoFinalFerreteria.Properties.Resources._669cbf70_fad9_465f_9024_dbe779f3d527_200x200BeFunky;
            this.LogoPictureBox.ImageLocation = "";
            this.LogoPictureBox.Location = new System.Drawing.Point(315, -9);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(159, 111);
            this.LogoPictureBox.TabIndex = 26;
            this.LogoPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cliente";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_error_de_impresora_30;
            this.ImprimirButton.Location = new System.Drawing.Point(483, 542);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(133, 52);
            this.ImprimirButton.TabIndex = 28;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // AgregarClienteButton
            // 
            this.AgregarClienteButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_más_26;
            this.AgregarClienteButton.Location = new System.Drawing.Point(268, 47);
            this.AgregarClienteButton.Name = "AgregarClienteButton";
            this.AgregarClienteButton.Size = new System.Drawing.Size(41, 25);
            this.AgregarClienteButton.TabIndex = 6;
            this.AgregarClienteButton.UseVisualStyleBackColor = true;
            this.AgregarClienteButton.Click += new System.EventHandler(this.AgregarClienteButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.NuevoIcon__1_;
            this.NuevoButton.Location = new System.Drawing.Point(12, 542);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(133, 52);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.GuardarIcon__1_;
            this.GuardarButton.Location = new System.Drawing.Point(240, 542);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(133, 52);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.borradoricon;
            this.EliminarButton.Location = new System.Drawing.Point(695, 542);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(133, 52);
            this.EliminarButton.TabIndex = 20;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::ProyectoFinalFerreteria.Properties.Resources.icons8_google_web_search_24;
            this.BuscarButton.Location = new System.Drawing.Point(123, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(96, 32);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Usuario";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTextBox.Location = new System.Drawing.Point(66, 77);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(196, 20);
            this.BalanceTextBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Comentario";
            // 
            // ComentariosRichTextBox
            // 
            this.ComentariosRichTextBox.Location = new System.Drawing.Point(644, 478);
            this.ComentariosRichTextBox.Name = "ComentariosRichTextBox";
            this.ComentariosRichTextBox.Size = new System.Drawing.Size(184, 53);
            this.ComentariosRichTextBox.TabIndex = 34;
            this.ComentariosRichTextBox.Text = "";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(360, 600);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(167, 20);
            this.UsuarioTextBox.TabIndex = 35;
            // 
            // RegistroFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(836, 628);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.ComentariosRichTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.AgregarClienteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoFacturaComboBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.CantidadArticulosTextBox);
            this.Controls.Add(this.DescuentosTextBox);
            this.Controls.Add(this.ITBISTextBox);
            this.Controls.Add(this.TotalGeneralTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ArticulosGroupBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistroFacturacion";
            this.Text = "Registro Facturación (Ferreteria Nelson)";
            this.Load += new System.EventHandler(this.RegistroFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            this.ArticulosGroupBox.ResumeLayout(false);
            this.ArticulosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button AgregarClienteButton;
        private System.Windows.Forms.GroupBox ArticulosGroupBox;
        private System.Windows.Forms.ComboBox DescripcionComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Button BuscarArticuloButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox TotalGeneralTextBox;
        private System.Windows.Forms.TextBox ITBISTextBox;
        private System.Windows.Forms.TextBox DescuentosTextBox;
        private System.Windows.Forms.TextBox CantidadArticulosTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Button AgregarAlGridButton;
        private System.Windows.Forms.ComboBox TipoFacturaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioUnitarioTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.RichTextBox ComentariosRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UnidadTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
    }
}