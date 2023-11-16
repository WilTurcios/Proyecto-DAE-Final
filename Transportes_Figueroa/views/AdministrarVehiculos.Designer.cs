namespace Transportes_Figueroa.views
{
    partial class AdministrarVehiculos
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
            this.DataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.IDAccionAgregarVehiculo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EliminarVehiculo = new System.Windows.Forms.Button();
            this.ActualizarVehiculo = new System.Windows.Forms.Button();
            this.AgregarVehiculo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.NumericUpDown();
            this.txtKilometraje = new System.Windows.Forms.NumericUpDown();
            this.ListaMarcas = new System.Windows.Forms.ComboBox();
            this.ListaModelos = new System.Windows.Forms.ComboBox();
            this.txtAnio = new System.Windows.Forms.NumericUpDown();
            this.txtCapacidadPeso = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapacidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.ListaTipoVehiculos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVehiculos
            // 
            this.DataGridVehiculos.AllowUserToAddRows = false;
            this.DataGridVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionAgregarVehiculo});
            this.DataGridVehiculos.Location = new System.Drawing.Point(83, 316);
            this.DataGridVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridVehiculos.Name = "DataGridVehiculos";
            this.DataGridVehiculos.Size = new System.Drawing.Size(917, 173);
            this.DataGridVehiculos.TabIndex = 27;
            this.DataGridVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVehiculos_CellContentClick);
            // 
            // IDAccionAgregarVehiculo
            // 
            this.IDAccionAgregarVehiculo.HeaderText = "#";
            this.IDAccionAgregarVehiculo.Name = "IDAccionAgregarVehiculo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubirImagen);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(83, 66);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(204, 232);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnSubirImagen.FlatAppearance.BorderSize = 0;
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirImagen.Location = new System.Drawing.Point(10, 198);
            this.btnSubirImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(187, 27);
            this.btnSubirImagen.TabIndex = 3;
            this.btnSubirImagen.Text = "Subir Imagen";
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EliminarVehiculo);
            this.groupBox2.Controls.Add(this.ActualizarVehiculo);
            this.groupBox2.Controls.Add(this.AgregarVehiculo);
            this.groupBox2.Location = new System.Drawing.Point(827, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(173, 232);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.EliminarVehiculo.FlatAppearance.BorderSize = 0;
            this.EliminarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarVehiculo.Location = new System.Drawing.Point(46, 89);
            this.EliminarVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.Size = new System.Drawing.Size(88, 27);
            this.EliminarVehiculo.TabIndex = 12;
            this.EliminarVehiculo.Text = "Eliminar";
            this.EliminarVehiculo.UseVisualStyleBackColor = false;
            this.EliminarVehiculo.Click += new System.EventHandler(this.EliminarVehiculo_Click);
            // 
            // ActualizarVehiculo
            // 
            this.ActualizarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.ActualizarVehiculo.FlatAppearance.BorderSize = 0;
            this.ActualizarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarVehiculo.Location = new System.Drawing.Point(46, 55);
            this.ActualizarVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ActualizarVehiculo.Name = "ActualizarVehiculo";
            this.ActualizarVehiculo.Size = new System.Drawing.Size(88, 27);
            this.ActualizarVehiculo.TabIndex = 11;
            this.ActualizarVehiculo.Text = "Actualizar";
            this.ActualizarVehiculo.UseVisualStyleBackColor = false;
            this.ActualizarVehiculo.Click += new System.EventHandler(this.ActualizarVehiculo_Click);
            // 
            // AgregarVehiculo
            // 
            this.AgregarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.AgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarVehiculo.Location = new System.Drawing.Point(46, 22);
            this.AgregarVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarVehiculo.Name = "AgregarVehiculo";
            this.AgregarVehiculo.Size = new System.Drawing.Size(88, 27);
            this.AgregarVehiculo.TabIndex = 10;
            this.AgregarVehiculo.Text = "Agregar";
            this.AgregarVehiculo.UseVisualStyleBackColor = false;
            this.AgregarVehiculo.Click += new System.EventHandler(this.AgregarVehiculo_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(1007, 14);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(88, 27);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtKilometraje);
            this.groupBox1.Controls.Add(this.ListaMarcas);
            this.groupBox1.Controls.Add(this.ListaModelos);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.txtCapacidadPeso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCapacidadPersonas);
            this.groupBox1.Controls.Add(this.ListaTipoVehiculos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(304, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(489, 232);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 201);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Costo por km u hora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 22;
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.DecimalPlaces = 2;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(255, 198);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCosto.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(217, 25);
            this.txtCosto.TabIndex = 9;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKilometraje.DecimalPlaces = 2;
            this.txtKilometraje.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.Location = new System.Drawing.Point(10, 81);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKilometraje.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(217, 25);
            this.txtKilometraje.TabIndex = 2;
            // 
            // ListaMarcas
            // 
            this.ListaMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaMarcas.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMarcas.FormattingEnabled = true;
            this.ListaMarcas.Location = new System.Drawing.Point(255, 36);
            this.ListaMarcas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaMarcas.Name = "ListaMarcas";
            this.ListaMarcas.Size = new System.Drawing.Size(216, 25);
            this.ListaMarcas.TabIndex = 5;
            // 
            // ListaModelos
            // 
            this.ListaModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaModelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaModelos.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaModelos.FormattingEnabled = true;
            this.ListaModelos.Location = new System.Drawing.Point(255, 80);
            this.ListaModelos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaModelos.Name = "ListaModelos";
            this.ListaModelos.Size = new System.Drawing.Size(216, 25);
            this.ListaModelos.TabIndex = 6;
            // 
            // txtAnio
            // 
            this.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnio.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(10, 127);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtAnio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(217, 25);
            this.txtAnio.TabIndex = 3;
            this.txtAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtCapacidadPeso
            // 
            this.txtCapacidadPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidadPeso.DecimalPlaces = 2;
            this.txtCapacidadPeso.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidadPeso.Location = new System.Drawing.Point(255, 172);
            this.txtCapacidadPeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCapacidadPeso.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.txtCapacidadPeso.Name = "txtCapacidadPeso";
            this.txtCapacidadPeso.Size = new System.Drawing.Size(217, 25);
            this.txtCapacidadPeso.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marca:";
            // 
            // txtCapacidadPersonas
            // 
            this.txtCapacidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidadPersonas.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidadPersonas.Location = new System.Drawing.Point(10, 172);
            this.txtCapacidadPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCapacidadPersonas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtCapacidadPersonas.Name = "txtCapacidadPersonas";
            this.txtCapacidadPersonas.Size = new System.Drawing.Size(217, 25);
            this.txtCapacidadPersonas.TabIndex = 4;
            // 
            // ListaTipoVehiculos
            // 
            this.ListaTipoVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaTipoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaTipoVehiculos.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaTipoVehiculos.FormattingEnabled = true;
            this.ListaTipoVehiculos.Location = new System.Drawing.Point(255, 126);
            this.ListaTipoVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaTipoVehiculos.Name = "ListaTipoVehiculos";
            this.ListaTipoVehiculos.Size = new System.Drawing.Size(216, 25);
            this.ListaTipoVehiculos.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Año:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.AllowDrop = true;
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(10, 37);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(216, 25);
            this.txtMatricula.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de vehículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Capacidad de peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacidad de personas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilometraje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula:";
            // 
            // CrearVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 561);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.DataGridVehiculos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CrearVehiculo";
            this.Text = "CrearVehiculo";
            this.Load += new System.EventHandler(this.CrearVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVehiculos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionAgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button EliminarVehiculo;
        private System.Windows.Forms.Button ActualizarVehiculo;
        private System.Windows.Forms.Button AgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtCosto;
        private System.Windows.Forms.NumericUpDown txtKilometraje;
        private System.Windows.Forms.ComboBox ListaMarcas;
        private System.Windows.Forms.ComboBox ListaModelos;
        private System.Windows.Forms.NumericUpDown txtAnio;
        private System.Windows.Forms.NumericUpDown txtCapacidadPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtCapacidadPersonas;
        private System.Windows.Forms.ComboBox ListaTipoVehiculos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}