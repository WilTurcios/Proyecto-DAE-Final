namespace Transportes_Figueroa.views
{
    partial class CrearVehiculo
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
            this.DataGridModelos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.IDAccionAgregarVehiculo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.EliminarVehiculo = new System.Windows.Forms.Button();
            this.ActualizarVehiculo = new System.Windows.Forms.Button();
            this.AgregarVehiculo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListaMarcas_vehiculos = new System.Windows.Forms.ComboBox();
            this.ListaModelos = new System.Windows.Forms.ComboBox();
            this.txtAnio = new System.Windows.Forms.NumericUpDown();
            this.txtCapacidadPeso = new System.Windows.Forms.NumericUpDown();
            this.txtCapacidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.ListaTipoVehiculos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EliminarMarca = new System.Windows.Forms.Button();
            this.AgregarMarca = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridMarcas = new System.Windows.Forms.DataGridView();
            this.IDAccionAgregarMarca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EliminarModelo = new System.Windows.Forms.Button();
            this.AgregarModelo = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ListaMarcas_modelos = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGridModelos1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtKilometraje = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DataGridModelos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPersonas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridModelos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridModelos
            // 
            this.DataGridModelos.Controls.Add(this.tabPage1);
            this.DataGridModelos.Controls.Add(this.tabPage2);
            this.DataGridModelos.Controls.Add(this.tabPage3);
            this.DataGridModelos.Location = new System.Drawing.Point(13, 3);
            this.DataGridModelos.Name = "DataGridModelos";
            this.DataGridModelos.SelectedIndex = 0;
            this.DataGridModelos.Size = new System.Drawing.Size(925, 471);
            this.DataGridModelos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGridVehiculos);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridVehiculos
            // 
            this.DataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionAgregarVehiculo});
            this.DataGridVehiculos.Location = new System.Drawing.Point(6, 223);
            this.DataGridVehiculos.Name = "DataGridVehiculos";
            this.DataGridVehiculos.Size = new System.Drawing.Size(786, 150);
            this.DataGridVehiculos.TabIndex = 23;
            this.DataGridVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVehiculos_CellContentClick);
            // 
            // IDAccionAgregarVehiculo
            // 
            this.IDAccionAgregarVehiculo.HeaderText = "#";
            this.IDAccionAgregarVehiculo.Name = "IDAccionAgregarVehiculo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 201);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Subir Imagen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.EliminarVehiculo);
            this.groupBox2.Controls.Add(this.ActualizarVehiculo);
            this.groupBox2.Controls.Add(this.AgregarVehiculo);
            this.groupBox2.Location = new System.Drawing.Point(644, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 201);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.Location = new System.Drawing.Point(39, 77);
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.EliminarVehiculo.TabIndex = 2;
            this.EliminarVehiculo.Text = "Eliminar";
            this.EliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // ActualizarVehiculo
            // 
            this.ActualizarVehiculo.Location = new System.Drawing.Point(39, 48);
            this.ActualizarVehiculo.Name = "ActualizarVehiculo";
            this.ActualizarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.ActualizarVehiculo.TabIndex = 1;
            this.ActualizarVehiculo.Text = "Actualizar";
            this.ActualizarVehiculo.UseVisualStyleBackColor = true;
            // 
            // AgregarVehiculo
            // 
            this.AgregarVehiculo.Location = new System.Drawing.Point(39, 19);
            this.AgregarVehiculo.Name = "AgregarVehiculo";
            this.AgregarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.AgregarVehiculo.TabIndex = 0;
            this.AgregarVehiculo.Text = "Agregar";
            this.AgregarVehiculo.UseVisualStyleBackColor = true;
            this.AgregarVehiculo.Click += new System.EventHandler(this.AgregarVehiculo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtKilometraje);
            this.groupBox1.Controls.Add(this.ListaMarcas_vehiculos);
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
            this.groupBox1.Location = new System.Drawing.Point(196, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 201);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // ListaMarcas_vehiculos
            // 
            this.ListaMarcas_vehiculos.FormattingEnabled = true;
            this.ListaMarcas_vehiculos.Location = new System.Drawing.Point(219, 31);
            this.ListaMarcas_vehiculos.Name = "ListaMarcas_vehiculos";
            this.ListaMarcas_vehiculos.Size = new System.Drawing.Size(186, 21);
            this.ListaMarcas_vehiculos.TabIndex = 19;
            this.ListaMarcas_vehiculos.SelectedIndexChanged += new System.EventHandler(this.ListaMarcas_vehiculos_SelectedIndexChanged);
            // 
            // ListaModelos
            // 
            this.ListaModelos.FormattingEnabled = true;
            this.ListaModelos.Location = new System.Drawing.Point(219, 69);
            this.ListaModelos.Name = "ListaModelos";
            this.ListaModelos.Size = new System.Drawing.Size(186, 21);
            this.ListaModelos.TabIndex = 18;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(9, 110);
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
            this.txtAnio.Size = new System.Drawing.Size(186, 20);
            this.txtAnio.TabIndex = 17;
            this.txtAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtCapacidadPeso
            // 
            this.txtCapacidadPeso.DecimalPlaces = 2;
            this.txtCapacidadPeso.Location = new System.Drawing.Point(219, 149);
            this.txtCapacidadPeso.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.txtCapacidadPeso.Name = "txtCapacidadPeso";
            this.txtCapacidadPeso.Size = new System.Drawing.Size(186, 20);
            this.txtCapacidadPeso.TabIndex = 16;
            // 
            // txtCapacidadPersonas
            // 
            this.txtCapacidadPersonas.Location = new System.Drawing.Point(9, 149);
            this.txtCapacidadPersonas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtCapacidadPersonas.Name = "txtCapacidadPersonas";
            this.txtCapacidadPersonas.Size = new System.Drawing.Size(186, 20);
            this.txtCapacidadPersonas.TabIndex = 15;
            // 
            // ListaTipoVehiculos
            // 
            this.ListaTipoVehiculos.FormattingEnabled = true;
            this.ListaTipoVehiculos.Location = new System.Drawing.Point(219, 109);
            this.ListaTipoVehiculos.Name = "ListaTipoVehiculos";
            this.ListaTipoVehiculos.Size = new System.Drawing.Size(186, 21);
            this.ListaTipoVehiculos.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Año:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(9, 32);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(186, 20);
            this.txtMatricula.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de vehículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Capacidad de peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacidad de personas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilometraje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.DataGridMarcas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar marca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EliminarMarca);
            this.groupBox5.Controls.Add(this.AgregarMarca);
            this.groupBox5.Location = new System.Drawing.Point(6, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 82);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // EliminarMarca
            // 
            this.EliminarMarca.Location = new System.Drawing.Point(107, 19);
            this.EliminarMarca.Name = "EliminarMarca";
            this.EliminarMarca.Size = new System.Drawing.Size(95, 50);
            this.EliminarMarca.TabIndex = 4;
            this.EliminarMarca.Text = "Eliminar";
            this.EliminarMarca.UseVisualStyleBackColor = true;
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.Location = new System.Drawing.Point(6, 19);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(95, 50);
            this.AgregarMarca.TabIndex = 3;
            this.AgregarMarca.Text = "Agregar";
            this.AgregarMarca.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMarca);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 63);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información general";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(9, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre:";
            // 
            // DataGridMarcas
            // 
            this.DataGridMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionAgregarMarca});
            this.DataGridMarcas.Location = new System.Drawing.Point(231, 7);
            this.DataGridMarcas.Name = "DataGridMarcas";
            this.DataGridMarcas.Size = new System.Drawing.Size(671, 150);
            this.DataGridMarcas.TabIndex = 0;
            // 
            // IDAccionAgregarMarca
            // 
            this.IDAccionAgregarMarca.HeaderText = "#";
            this.IDAccionAgregarMarca.Name = "IDAccionAgregarMarca";
            this.IDAccionAgregarMarca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDAccionAgregarMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.DataGridModelos1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(917, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Agregar modelo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EliminarModelo);
            this.groupBox6.Controls.Add(this.AgregarModelo);
            this.groupBox6.Location = new System.Drawing.Point(9, 135);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 82);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Acciones";
            // 
            // EliminarModelo
            // 
            this.EliminarModelo.Location = new System.Drawing.Point(107, 19);
            this.EliminarModelo.Name = "EliminarModelo";
            this.EliminarModelo.Size = new System.Drawing.Size(95, 50);
            this.EliminarModelo.TabIndex = 4;
            this.EliminarModelo.Text = "Eliminar";
            this.EliminarModelo.UseVisualStyleBackColor = true;
            // 
            // AgregarModelo
            // 
            this.AgregarModelo.Location = new System.Drawing.Point(6, 19);
            this.AgregarModelo.Name = "AgregarModelo";
            this.AgregarModelo.Size = new System.Drawing.Size(95, 50);
            this.AgregarModelo.TabIndex = 3;
            this.AgregarModelo.Text = "Agregar";
            this.AgregarModelo.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.ListaMarcas_modelos);
            this.groupBox7.Controls.Add(this.txtModelo);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(9, 11);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(209, 118);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Información general";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Marca:";
            // 
            // ListaMarcas_modelos
            // 
            this.ListaMarcas_modelos.FormattingEnabled = true;
            this.ListaMarcas_modelos.Location = new System.Drawing.Point(9, 78);
            this.ListaMarcas_modelos.Name = "ListaMarcas_modelos";
            this.ListaMarcas_modelos.Size = new System.Drawing.Size(188, 21);
            this.ListaMarcas_modelos.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(9, 32);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(188, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Modelo:";
            // 
            // DataGridModelos1
            // 
            this.DataGridModelos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridModelos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.DataGridModelos1.Location = new System.Drawing.Point(234, 12);
            this.DataGridModelos1.Name = "DataGridModelos1";
            this.DataGridModelos1.Size = new System.Drawing.Size(671, 205);
            this.DataGridModelos1.TabIndex = 3;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "#";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.DecimalPlaces = 2;
            this.txtKilometraje.Location = new System.Drawing.Point(9, 70);
            this.txtKilometraje.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(186, 20);
            this.txtKilometraje.TabIndex = 20;
            // 
            // txtCosto
            // 
            this.txtCosto.DecimalPlaces = 2;
            this.txtCosto.Location = new System.Drawing.Point(219, 172);
            this.txtCosto.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(186, 20);
            this.txtCosto.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Costo por km u hora:";
            // 
            // CrearVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 486);
            this.Controls.Add(this.DataGridModelos);
            this.Name = "CrearVehiculo";
            this.Text = "CrearVehiculo";
            this.Load += new System.EventHandler(this.CrearVehiculo_Load);
            this.DataGridModelos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadPersonas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridModelos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DataGridModelos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataGridVehiculos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EliminarVehiculo;
        private System.Windows.Forms.Button ActualizarVehiculo;
        private System.Windows.Forms.Button AgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ListaMarcas_vehiculos;
        private System.Windows.Forms.ComboBox ListaModelos;
        private System.Windows.Forms.NumericUpDown txtAnio;
        private System.Windows.Forms.NumericUpDown txtCapacidadPeso;
        private System.Windows.Forms.NumericUpDown txtCapacidadPersonas;
        private System.Windows.Forms.ComboBox ListaTipoVehiculos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataGridMarcas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionAgregarVehiculo;
        private System.Windows.Forms.Button EliminarMarca;
        private System.Windows.Forms.Button AgregarMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionAgregarMarca;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button EliminarModelo;
        private System.Windows.Forms.Button AgregarModelo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ListaMarcas_modelos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridModelos1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.NumericUpDown txtKilometraje;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtCosto;
    }
}