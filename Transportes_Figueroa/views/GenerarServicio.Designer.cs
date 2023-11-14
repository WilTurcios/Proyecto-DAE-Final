namespace Transportes_Figueroa.views
{
    partial class GenerarServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaVehiculos = new System.Windows.Forms.ListView();
            this.IDVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarcaVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModeloVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostoVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DUI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.ListaTipoServicios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListaMarcas = new System.Windows.Forms.ComboBox();
            this.ListaModelos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMedido = new System.Windows.Forms.NumericUpDown();
            this.AgregarServicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.txtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridServiciosCliente = new System.Windows.Forms.DataGridView();
            this.IDAccionServicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitudServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ListaFiltrosCliente = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ListaConductores = new System.Windows.Forms.ComboBox();
            this.SeleccionarCliente = new System.Windows.Forms.Button();
            this.SeleccionarVehiculo = new System.Windows.Forms.Button();
            this.QuitarSeleccionVehiculo = new System.Windows.Forms.Button();
            this.QuitarSeleccionCliente = new System.Windows.Forms.Button();
            this.btnQuitarFiltros = new System.Windows.Forms.Button();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServiciosCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige el cliente al que se le generará el servicio";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de servicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Alquilado:";
            // 
            // ListaVehiculos
            // 
            this.ListaVehiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVehiculo,
            this.MarcaVehiculo,
            this.ModeloVehiculo,
            this.CostoVehiculo});
            this.ListaVehiculos.HideSelection = false;
            this.ListaVehiculos.Location = new System.Drawing.Point(15, 23);
            this.ListaVehiculos.Name = "ListaVehiculos";
            this.ListaVehiculos.Size = new System.Drawing.Size(263, 298);
            this.ListaVehiculos.TabIndex = 3;
            this.ListaVehiculos.UseCompatibleStateImageBehavior = false;
            this.ListaVehiculos.SelectedIndexChanged += new System.EventHandler(this.ListaVehiculos_SelectedIndexChanged);
            // 
            // IDVehiculo
            // 
            this.IDVehiculo.Text = "ID";
            // 
            // MarcaVehiculo
            // 
            this.MarcaVehiculo.Text = "Marca";
            // 
            // ModeloVehiculo
            // 
            this.ModeloVehiculo.Text = "Modelo";
            // 
            // CostoVehiculo
            // 
            this.CostoVehiculo.Text = "Costo por km u hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Elige el vehiculo asignado al servicio";
            // 
            // ListaClientes
            // 
            this.ListaClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.DUI,
            this.ID});
            this.ListaClientes.HideSelection = false;
            this.ListaClientes.Location = new System.Drawing.Point(284, 23);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(346, 298);
            this.ListaClientes.TabIndex = 5;
            this.ListaClientes.UseCompatibleStateImageBehavior = false;
            this.ListaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 100;
            // 
            // DUI
            // 
            this.DUI.Text = "DUI";
            this.DUI.Width = 100;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtrar por:";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(9, 74);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(179, 20);
            this.txtFiltroCliente.TabIndex = 7;
            // 
            // ListaTipoServicios
            // 
            this.ListaTipoServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaTipoServicios.FormattingEnabled = true;
            this.ListaTipoServicios.Location = new System.Drawing.Point(757, 47);
            this.ListaTipoServicios.Name = "ListaTipoServicios";
            this.ListaTipoServicios.Size = new System.Drawing.Size(186, 21);
            this.ListaTipoServicios.TabIndex = 8;
            this.ListaTipoServicios.SelectedIndexChanged += new System.EventHandler(this.ListaTipoServicios_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca:";
            // 
            // ListaMarcas
            // 
            this.ListaMarcas.FormattingEnabled = true;
            this.ListaMarcas.Location = new System.Drawing.Point(52, 18);
            this.ListaMarcas.Name = "ListaMarcas";
            this.ListaMarcas.Size = new System.Drawing.Size(228, 21);
            this.ListaMarcas.TabIndex = 10;
            this.ListaMarcas.SelectedIndexChanged += new System.EventHandler(this.ListaMarcas_SelectedIndexChanged);
            // 
            // ListaModelos
            // 
            this.ListaModelos.FormattingEnabled = true;
            this.ListaModelos.Location = new System.Drawing.Point(52, 45);
            this.ListaModelos.Name = "ListaModelos";
            this.ListaModelos.Size = new System.Drawing.Size(228, 21);
            this.ListaModelos.TabIndex = 12;
            this.ListaModelos.SelectedIndexChanged += new System.EventHandler(this.ListaModelos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Modelo:";
            // 
            // txtValorMedido
            // 
            this.txtValorMedido.DecimalPlaces = 2;
            this.txtValorMedido.Location = new System.Drawing.Point(6, 36);
            this.txtValorMedido.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtValorMedido.Name = "txtValorMedido";
            this.txtValorMedido.Size = new System.Drawing.Size(280, 20);
            this.txtValorMedido.TabIndex = 13;
            // 
            // AgregarServicio
            // 
            this.AgregarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarServicio.Location = new System.Drawing.Point(651, 497);
            this.AgregarServicio.Name = "AgregarServicio";
            this.AgregarServicio.Size = new System.Drawing.Size(75, 31);
            this.AgregarServicio.TabIndex = 14;
            this.AgregarServicio.Text = "Agregar";
            this.AgregarServicio.UseVisualStyleBackColor = true;
            this.AgregarServicio.Click += new System.EventHandler(this.AgregarServicio_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(813, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generar Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Location = new System.Drawing.Point(868, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 24);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelar.Location = new System.Drawing.Point(732, 497);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 31);
            this.Cancelar.TabIndex = 17;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.CustomFormat = "dd-MM-yyyy HH:mm";
            this.txtFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaDevolucion.Location = new System.Drawing.Point(6, 114);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(280, 20);
            this.txtFechaDevolucion.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha de devolución:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha de solicitud:";
            // 
            // txtFechaSolicitud
            // 
            this.txtFechaSolicitud.CustomFormat = "dd-MM-yyyy HH:mm";
            this.txtFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaSolicitud.Location = new System.Drawing.Point(6, 75);
            this.txtFechaSolicitud.Name = "txtFechaSolicitud";
            this.txtFechaSolicitud.Size = new System.Drawing.Size(280, 20);
            this.txtFechaSolicitud.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Servicios solicitados:";
            // 
            // DataGridServiciosCliente
            // 
            this.DataGridServiciosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServiciosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionServicio,
            this.IDServicio,
            this.TipoServicio,
            this.FechaSolicitudServicio,
            this.FechaDevolucionServicio,
            this.MontoServicio});
            this.DataGridServiciosCliente.Location = new System.Drawing.Point(15, 380);
            this.DataGridServiciosCliente.Name = "DataGridServiciosCliente";
            this.DataGridServiciosCliente.Size = new System.Drawing.Size(615, 150);
            this.DataGridServiciosCliente.TabIndex = 23;
            // 
            // IDAccionServicio
            // 
            this.IDAccionServicio.HeaderText = "#";
            this.IDAccionServicio.Name = "IDAccionServicio";
            this.IDAccionServicio.Width = 50;
            // 
            // IDServicio
            // 
            this.IDServicio.DataPropertyName = "id_servicio";
            this.IDServicio.HeaderText = "ID";
            this.IDServicio.Name = "IDServicio";
            // 
            // TipoServicio
            // 
            this.TipoServicio.DataPropertyName = "tipo_servicio";
            this.TipoServicio.HeaderText = "Tipo de servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.Width = 120;
            // 
            // FechaSolicitudServicio
            // 
            this.FechaSolicitudServicio.DataPropertyName = "fecha_solicitud";
            this.FechaSolicitudServicio.HeaderText = "Fecha de solicitud";
            this.FechaSolicitudServicio.Name = "FechaSolicitudServicio";
            // 
            // FechaDevolucionServicio
            // 
            this.FechaDevolucionServicio.DataPropertyName = "fecha_devolucion";
            this.FechaDevolucionServicio.HeaderText = "Fecha de devolución";
            this.FechaDevolucionServicio.Name = "FechaDevolucionServicio";
            // 
            // MontoServicio
            // 
            this.MontoServicio.DataPropertyName = "monto";
            this.MontoServicio.HeaderText = "Monto a pagar";
            this.MontoServicio.Name = "MontoServicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFechaSolicitud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorMedido);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFechaDevolucion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(651, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del servicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFiltrarCliente);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ListaFiltrosCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFiltroCliente);
            this.groupBox2.Location = new System.Drawing.Point(651, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 106);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Burcar cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Escribe según el parámetro a buscar:";
            // 
            // ListaFiltrosCliente
            // 
            this.ListaFiltrosCliente.FormattingEnabled = true;
            this.ListaFiltrosCliente.Items.AddRange(new object[] {
            "DUI",
            "Nombre"});
            this.ListaFiltrosCliente.Location = new System.Drawing.Point(65, 23);
            this.ListaFiltrosCliente.Name = "ListaFiltrosCliente";
            this.ListaFiltrosCliente.Size = new System.Drawing.Size(215, 21);
            this.ListaFiltrosCliente.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ListaMarcas);
            this.groupBox3.Controls.Add(this.ListaModelos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(651, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 77);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar vehículo";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Conductor: ";
            // 
            // ListaConductores
            // 
            this.ListaConductores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaConductores.FormattingEnabled = true;
            this.ListaConductores.Location = new System.Drawing.Point(757, 81);
            this.ListaConductores.Name = "ListaConductores";
            this.ListaConductores.Size = new System.Drawing.Size(186, 21);
            this.ListaConductores.TabIndex = 28;
            // 
            // SeleccionarCliente
            // 
            this.SeleccionarCliente.Location = new System.Drawing.Point(284, 326);
            this.SeleccionarCliente.Name = "SeleccionarCliente";
            this.SeleccionarCliente.Size = new System.Drawing.Size(130, 23);
            this.SeleccionarCliente.TabIndex = 29;
            this.SeleccionarCliente.Text = "Seleccionar cliente";
            this.SeleccionarCliente.UseVisualStyleBackColor = true;
            this.SeleccionarCliente.Click += new System.EventHandler(this.SeleccionarCliente_Click);
            // 
            // SeleccionarVehiculo
            // 
            this.SeleccionarVehiculo.Location = new System.Drawing.Point(15, 327);
            this.SeleccionarVehiculo.Name = "SeleccionarVehiculo";
            this.SeleccionarVehiculo.Size = new System.Drawing.Size(120, 23);
            this.SeleccionarVehiculo.TabIndex = 30;
            this.SeleccionarVehiculo.Text = "Seleccionar vehiculo";
            this.SeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.SeleccionarVehiculo.Click += new System.EventHandler(this.SeleccionarVehiculo_Click);
            // 
            // QuitarSeleccionVehiculo
            // 
            this.QuitarSeleccionVehiculo.Location = new System.Drawing.Point(141, 327);
            this.QuitarSeleccionVehiculo.Name = "QuitarSeleccionVehiculo";
            this.QuitarSeleccionVehiculo.Size = new System.Drawing.Size(120, 23);
            this.QuitarSeleccionVehiculo.TabIndex = 31;
            this.QuitarSeleccionVehiculo.Text = "Quitar seleccion";
            this.QuitarSeleccionVehiculo.UseVisualStyleBackColor = true;
            this.QuitarSeleccionVehiculo.Click += new System.EventHandler(this.QuitarSeleccionVehiculo_Click);
            // 
            // QuitarSeleccionCliente
            // 
            this.QuitarSeleccionCliente.Location = new System.Drawing.Point(420, 326);
            this.QuitarSeleccionCliente.Name = "QuitarSeleccionCliente";
            this.QuitarSeleccionCliente.Size = new System.Drawing.Size(120, 23);
            this.QuitarSeleccionCliente.TabIndex = 32;
            this.QuitarSeleccionCliente.Text = "Quitar seleccion";
            this.QuitarSeleccionCliente.UseVisualStyleBackColor = true;
            this.QuitarSeleccionCliente.Click += new System.EventHandler(this.QuitarSeleccionCliente_Click);
            // 
            // btnQuitarFiltros
            // 
            this.btnQuitarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarFiltros.Location = new System.Drawing.Point(826, 311);
            this.btnQuitarFiltros.Name = "btnQuitarFiltros";
            this.btnQuitarFiltros.Size = new System.Drawing.Size(117, 23);
            this.btnQuitarFiltros.TabIndex = 34;
            this.btnQuitarFiltros.Text = "Quitar Filtros";
            this.btnQuitarFiltros.UseVisualStyleBackColor = true;
            this.btnQuitarFiltros.Click += new System.EventHandler(this.btnQuitarFiltros_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(200, 72);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(86, 23);
            this.btnFiltrarCliente.TabIndex = 35;
            this.btnFiltrarCliente.Text = "Buscar";
            this.btnFiltrarCliente.UseVisualStyleBackColor = true;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // GenerarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 537);
            this.Controls.Add(this.btnQuitarFiltros);
            this.Controls.Add(this.QuitarSeleccionCliente);
            this.Controls.Add(this.QuitarSeleccionVehiculo);
            this.Controls.Add(this.SeleccionarVehiculo);
            this.Controls.Add(this.SeleccionarCliente);
            this.Controls.Add(this.ListaConductores);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridServiciosCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AgregarServicio);
            this.Controls.Add(this.ListaTipoServicios);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarServicio";
            this.Text = "GenerarServicio";
            this.Load += new System.EventHandler(this.GenerarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServiciosCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListaVehiculos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListaClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.ComboBox ListaTipoServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ListaMarcas;
        private System.Windows.Forms.ComboBox ListaModelos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtValorMedido;
        private System.Windows.Forms.Button AgregarServicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DateTimePicker txtFechaDevolucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaSolicitud;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridServiciosCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitudServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ListaFiltrosCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ListaConductores;
        private System.Windows.Forms.ColumnHeader IDVehiculo;
        private System.Windows.Forms.ColumnHeader MarcaVehiculo;
        private System.Windows.Forms.ColumnHeader ModeloVehiculo;
        private System.Windows.Forms.ColumnHeader CostoVehiculo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader DUI;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button SeleccionarCliente;
        private System.Windows.Forms.Button SeleccionarVehiculo;
        private System.Windows.Forms.Button QuitarSeleccionVehiculo;
        private System.Windows.Forms.Button QuitarSeleccionCliente;
        private System.Windows.Forms.Button btnQuitarFiltros;
        private System.Windows.Forms.Button btnFiltrarCliente;
    }
}