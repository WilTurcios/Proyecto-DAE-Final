namespace Transportes_Figueroa.views
{
    partial class AdministrarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarEmpleados));
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.QuitarSeleccion = new System.Windows.Forms.Button();
            this.MostrarTodosLosEmpleados = new System.Windows.Forms.Button();
            this.AgregarFotoEmpleado = new System.Windows.Forms.Button();
            this.FotoEmpleado = new System.Windows.Forms.PictureBox();
            this.ListaEmpleados = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiltroPorRol = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDireccion = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodCasa = new System.Windows.Forms.TextBox();
            this.ListaMunicipios = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.ListaDepartamentos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMostrarDireccion = new System.Windows.Forms.Button();
            this.PanelRol = new System.Windows.Forms.TableLayoutPanel();
            this.ListaRolesEmpleado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMostrarRolEmpleado = new System.Windows.Forms.Button();
            this.PanelDatosUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaRolesUsuario = new System.Windows.Forms.ComboBox();
            this.btnMostrarDatosUsuario = new System.Windows.Forms.Button();
            this.PanelDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCodSeguro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodAFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnMostrarDatosGenerales = new System.Windows.Forms.Button();
            this.EliminarEmpleado = new System.Windows.Forms.Button();
            this.ActualizarEmpleado = new System.Windows.Forms.Button();
            this.AgregarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoEmpleado)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelDireccion.SuspendLayout();
            this.PanelRol.SuspendLayout();
            this.PanelDatosUsuario.SuspendLayout();
            this.PanelDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1073, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 53;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 15);
            this.label20.TabIndex = 75;
            this.label20.Text = "Filtrar por rol:";
            // 
            // QuitarSeleccion
            // 
            this.QuitarSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.QuitarSeleccion.FlatAppearance.BorderSize = 0;
            this.QuitarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitarSeleccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitarSeleccion.Location = new System.Drawing.Point(229, 515);
            this.QuitarSeleccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuitarSeleccion.Name = "QuitarSeleccion";
            this.QuitarSeleccion.Size = new System.Drawing.Size(88, 40);
            this.QuitarSeleccion.TabIndex = 74;
            this.QuitarSeleccion.Text = "Quitar selección";
            this.QuitarSeleccion.UseVisualStyleBackColor = false;
            this.QuitarSeleccion.Click += new System.EventHandler(this.QuitarSeleccion_Click);
            // 
            // MostrarTodosLosEmpleados
            // 
            this.MostrarTodosLosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MostrarTodosLosEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.MostrarTodosLosEmpleados.FlatAppearance.BorderSize = 0;
            this.MostrarTodosLosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarTodosLosEmpleados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTodosLosEmpleados.Location = new System.Drawing.Point(512, 73);
            this.MostrarTodosLosEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MostrarTodosLosEmpleados.Name = "MostrarTodosLosEmpleados";
            this.MostrarTodosLosEmpleados.Size = new System.Drawing.Size(88, 24);
            this.MostrarTodosLosEmpleados.TabIndex = 73;
            this.MostrarTodosLosEmpleados.Text = "Todos";
            this.MostrarTodosLosEmpleados.UseVisualStyleBackColor = false;
            this.MostrarTodosLosEmpleados.Click += new System.EventHandler(this.MostrarTodosLosEmpleados_Click);
            // 
            // AgregarFotoEmpleado
            // 
            this.AgregarFotoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarFotoEmpleado.FlatAppearance.BorderSize = 0;
            this.AgregarFotoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarFotoEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarFotoEmpleado.Location = new System.Drawing.Point(27, 310);
            this.AgregarFotoEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarFotoEmpleado.Name = "AgregarFotoEmpleado";
            this.AgregarFotoEmpleado.Size = new System.Drawing.Size(289, 42);
            this.AgregarFotoEmpleado.TabIndex = 72;
            this.AgregarFotoEmpleado.Text = "Cargar foto";
            this.AgregarFotoEmpleado.UseVisualStyleBackColor = false;
            this.AgregarFotoEmpleado.Click += new System.EventHandler(this.AgregarFotoEmpleado_Click);
            // 
            // FotoEmpleado
            // 
            this.FotoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoEmpleado.Location = new System.Drawing.Point(27, 47);
            this.FotoEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FotoEmpleado.Name = "FotoEmpleado";
            this.FotoEmpleado.Size = new System.Drawing.Size(289, 260);
            this.FotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoEmpleado.TabIndex = 71;
            this.FotoEmpleado.TabStop = false;
            // 
            // ListaEmpleados
            // 
            this.ListaEmpleados.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListaEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(141)))), ((int)(((byte)(172)))));
            this.ListaEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.ID});
            this.ListaEmpleados.HideSelection = false;
            this.ListaEmpleados.Location = new System.Drawing.Point(323, 106);
            this.ListaEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaEmpleados.Name = "ListaEmpleados";
            this.ListaEmpleados.Size = new System.Drawing.Size(276, 448);
            this.ListaEmpleados.TabIndex = 70;
            this.ListaEmpleados.UseCompatibleStateImageBehavior = false;
            this.ListaEmpleados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListaEmpleados_ItemSelectionChanged);
            this.ListaEmpleados.SelectedIndexChanged += new System.EventHandler(this.ListaEmpleados_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 200;
            // 
            // FiltroPorRol
            // 
            this.FiltroPorRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroPorRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroPorRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiltroPorRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroPorRol.FormattingEnabled = true;
            this.FiltroPorRol.Location = new System.Drawing.Point(323, 73);
            this.FiltroPorRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FiltroPorRol.Name = "FiltroPorRol";
            this.FiltroPorRol.Size = new System.Drawing.Size(178, 25);
            this.FiltroPorRol.TabIndex = 69;
            this.FiltroPorRol.SelectedIndexChanged += new System.EventHandler(this.FiltroPorRol_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PanelDireccion);
            this.panel1.Controls.Add(this.btnMostrarDireccion);
            this.panel1.Controls.Add(this.PanelRol);
            this.panel1.Controls.Add(this.btnMostrarRolEmpleado);
            this.panel1.Controls.Add(this.PanelDatosUsuario);
            this.panel1.Controls.Add(this.btnMostrarDatosUsuario);
            this.panel1.Controls.Add(this.PanelDatosGenerales);
            this.panel1.Controls.Add(this.btnMostrarDatosGenerales);
            this.panel1.Location = new System.Drawing.Point(620, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 507);
            this.panel1.TabIndex = 68;
            // 
            // PanelDireccion
            // 
            this.PanelDireccion.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PanelDireccion.ColumnCount = 2;
            this.PanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDireccion.Controls.Add(this.txtCodCasa, 1, 4);
            this.PanelDireccion.Controls.Add(this.ListaMunicipios, 1, 1);
            this.PanelDireccion.Controls.Add(this.label10, 0, 4);
            this.PanelDireccion.Controls.Add(this.txtCalle, 1, 3);
            this.PanelDireccion.Controls.Add(this.label6, 0, 0);
            this.PanelDireccion.Controls.Add(this.label11, 0, 3);
            this.PanelDireccion.Controls.Add(this.txtUbicacion, 1, 2);
            this.PanelDireccion.Controls.Add(this.ListaDepartamentos, 1, 0);
            this.PanelDireccion.Controls.Add(this.label12, 0, 2);
            this.PanelDireccion.Controls.Add(this.label13, 0, 1);
            this.PanelDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDireccion.Location = new System.Drawing.Point(0, 452);
            this.PanelDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelDireccion.Name = "PanelDireccion";
            this.PanelDireccion.RowCount = 5;
            this.PanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDireccion.Size = new System.Drawing.Size(522, 160);
            this.PanelDireccion.TabIndex = 53;
            // 
            // txtCodCasa
            // 
            this.txtCodCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodCasa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCasa.Location = new System.Drawing.Point(265, 124);
            this.txtCodCasa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodCasa.Name = "txtCodCasa";
            this.txtCodCasa.Size = new System.Drawing.Size(252, 25);
            this.txtCodCasa.TabIndex = 52;
            // 
            // ListaMunicipios
            // 
            this.ListaMunicipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaMunicipios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaMunicipios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMunicipios.FormattingEnabled = true;
            this.ListaMunicipios.Location = new System.Drawing.Point(265, 34);
            this.ListaMunicipios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaMunicipios.Name = "ListaMunicipios";
            this.ListaMunicipios.Size = new System.Drawing.Size(252, 25);
            this.ListaMunicipios.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(5, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 38);
            this.label10.TabIndex = 46;
            this.label10.Text = "Numero de casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(265, 94);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(252, 25);
            this.txtCalle.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(5, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Departamento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(5, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 29);
            this.label11.TabIndex = 47;
            this.label11.Text = "Calle:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(265, 64);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(252, 25);
            this.txtUbicacion.TabIndex = 50;
            // 
            // ListaDepartamentos
            // 
            this.ListaDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaDepartamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDepartamentos.FormattingEnabled = true;
            this.ListaDepartamentos.Location = new System.Drawing.Point(265, 4);
            this.ListaDepartamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaDepartamentos.Name = "ListaDepartamentos";
            this.ListaDepartamentos.Size = new System.Drawing.Size(252, 25);
            this.ListaDepartamentos.TabIndex = 53;
            this.ListaDepartamentos.SelectedIndexChanged += new System.EventHandler(this.ListaDepartamentos_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(5, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 29);
            this.label12.TabIndex = 48;
            this.label12.Text = "Barrio/colonia:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(5, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 29);
            this.label13.TabIndex = 49;
            this.label13.Text = "Municipio:";
            // 
            // btnMostrarDireccion
            // 
            this.btnMostrarDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnMostrarDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarDireccion.FlatAppearance.BorderSize = 0;
            this.btnMostrarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarDireccion.Image")));
            this.btnMostrarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarDireccion.Location = new System.Drawing.Point(0, 425);
            this.btnMostrarDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarDireccion.Name = "btnMostrarDireccion";
            this.btnMostrarDireccion.Size = new System.Drawing.Size(522, 27);
            this.btnMostrarDireccion.TabIndex = 52;
            this.btnMostrarDireccion.Text = "Dirección del empleado";
            this.btnMostrarDireccion.UseVisualStyleBackColor = false;
            this.btnMostrarDireccion.Click += new System.EventHandler(this.btnMostrarDireccion_Click);
            // 
            // PanelRol
            // 
            this.PanelRol.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PanelRol.ColumnCount = 2;
            this.PanelRol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelRol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelRol.Controls.Add(this.ListaRolesEmpleado, 1, 0);
            this.PanelRol.Controls.Add(this.label9, 0, 0);
            this.PanelRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRol.Location = new System.Drawing.Point(0, 393);
            this.PanelRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelRol.Name = "PanelRol";
            this.PanelRol.RowCount = 1;
            this.PanelRol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.PanelRol.Size = new System.Drawing.Size(522, 32);
            this.PanelRol.TabIndex = 51;
            // 
            // ListaRolesEmpleado
            // 
            this.ListaRolesEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaRolesEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaRolesEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaRolesEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRolesEmpleado.FormattingEnabled = true;
            this.ListaRolesEmpleado.Location = new System.Drawing.Point(265, 4);
            this.ListaRolesEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaRolesEmpleado.Name = "ListaRolesEmpleado";
            this.ListaRolesEmpleado.Size = new System.Drawing.Size(252, 25);
            this.ListaRolesEmpleado.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(5, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 77);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rol del empleado:";
            // 
            // btnMostrarRolEmpleado
            // 
            this.btnMostrarRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnMostrarRolEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarRolEmpleado.FlatAppearance.BorderSize = 0;
            this.btnMostrarRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRolEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRolEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarRolEmpleado.Image")));
            this.btnMostrarRolEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarRolEmpleado.Location = new System.Drawing.Point(0, 366);
            this.btnMostrarRolEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarRolEmpleado.Name = "btnMostrarRolEmpleado";
            this.btnMostrarRolEmpleado.Size = new System.Drawing.Size(522, 27);
            this.btnMostrarRolEmpleado.TabIndex = 50;
            this.btnMostrarRolEmpleado.Text = "Rol de empleado";
            this.btnMostrarRolEmpleado.UseVisualStyleBackColor = false;
            this.btnMostrarRolEmpleado.Click += new System.EventHandler(this.btnMostrarRolEmpleado_Click);
            // 
            // PanelDatosUsuario
            // 
            this.PanelDatosUsuario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PanelDatosUsuario.ColumnCount = 2;
            this.PanelDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDatosUsuario.Controls.Add(this.label16, 0, 2);
            this.PanelDatosUsuario.Controls.Add(this.label4, 0, 0);
            this.PanelDatosUsuario.Controls.Add(this.txtCorreo, 1, 0);
            this.PanelDatosUsuario.Controls.Add(this.txtContrasenia, 1, 1);
            this.PanelDatosUsuario.Controls.Add(this.label5, 0, 1);
            this.PanelDatosUsuario.Controls.Add(this.ListaRolesUsuario, 1, 2);
            this.PanelDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDatosUsuario.Location = new System.Drawing.Point(0, 273);
            this.PanelDatosUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelDatosUsuario.Name = "PanelDatosUsuario";
            this.PanelDatosUsuario.RowCount = 3;
            this.PanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosUsuario.Size = new System.Drawing.Size(522, 93);
            this.PanelDatosUsuario.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(5, 61);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(251, 31);
            this.label16.TabIndex = 50;
            this.label16.Text = "Rol de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(265, 4);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(252, 25);
            this.txtCorreo.TabIndex = 24;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(265, 34);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(252, 25);
            this.txtContrasenia.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // ListaRolesUsuario
            // 
            this.ListaRolesUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaRolesUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaRolesUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRolesUsuario.FormattingEnabled = true;
            this.ListaRolesUsuario.Location = new System.Drawing.Point(265, 64);
            this.ListaRolesUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaRolesUsuario.Name = "ListaRolesUsuario";
            this.ListaRolesUsuario.Size = new System.Drawing.Size(252, 25);
            this.ListaRolesUsuario.TabIndex = 31;
            // 
            // btnMostrarDatosUsuario
            // 
            this.btnMostrarDatosUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnMostrarDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarDatosUsuario.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatosUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDatosUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarDatosUsuario.Image")));
            this.btnMostrarDatosUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarDatosUsuario.Location = new System.Drawing.Point(0, 246);
            this.btnMostrarDatosUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarDatosUsuario.Name = "btnMostrarDatosUsuario";
            this.btnMostrarDatosUsuario.Size = new System.Drawing.Size(522, 27);
            this.btnMostrarDatosUsuario.TabIndex = 48;
            this.btnMostrarDatosUsuario.Text = "Datos de usuario";
            this.btnMostrarDatosUsuario.UseVisualStyleBackColor = false;
            this.btnMostrarDatosUsuario.Click += new System.EventHandler(this.btnMostrarDatosUsuario_Click);
            // 
            // PanelDatosGenerales
            // 
            this.PanelDatosGenerales.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PanelDatosGenerales.ColumnCount = 2;
            this.PanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDatosGenerales.Controls.Add(this.label17, 0, 6);
            this.PanelDatosGenerales.Controls.Add(this.txtCodSeguro, 1, 5);
            this.PanelDatosGenerales.Controls.Add(this.label2, 0, 1);
            this.PanelDatosGenerales.Controls.Add(this.txtNombres, 1, 0);
            this.PanelDatosGenerales.Controls.Add(this.txtCodAFP, 1, 4);
            this.PanelDatosGenerales.Controls.Add(this.label1, 0, 0);
            this.PanelDatosGenerales.Controls.Add(this.label3, 0, 2);
            this.PanelDatosGenerales.Controls.Add(this.label7, 0, 4);
            this.PanelDatosGenerales.Controls.Add(this.txtApellidoPaterno, 1, 1);
            this.PanelDatosGenerales.Controls.Add(this.txtTelefono, 1, 3);
            this.PanelDatosGenerales.Controls.Add(this.txtApellidoMaterno, 1, 2);
            this.PanelDatosGenerales.Controls.Add(this.label8, 0, 3);
            this.PanelDatosGenerales.Controls.Add(this.label14, 0, 5);
            this.PanelDatosGenerales.Controls.Add(this.txtDUI, 1, 6);
            this.PanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDatosGenerales.Location = new System.Drawing.Point(0, 27);
            this.PanelDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelDatosGenerales.Name = "PanelDatosGenerales";
            this.PanelDatosGenerales.RowCount = 7;
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.PanelDatosGenerales.Size = new System.Drawing.Size(522, 219);
            this.PanelDatosGenerales.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(5, 181);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 37);
            this.label17.TabIndex = 28;
            this.label17.Text = "DUI";
            // 
            // txtCodSeguro
            // 
            this.txtCodSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodSeguro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodSeguro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguro.Location = new System.Drawing.Point(265, 154);
            this.txtCodSeguro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodSeguro.Name = "txtCodSeguro";
            this.txtCodSeguro.Size = new System.Drawing.Size(252, 25);
            this.txtCodSeguro.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(265, 4);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(252, 25);
            this.txtNombres.TabIndex = 14;
            // 
            // txtCodAFP
            // 
            this.txtCodAFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodAFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodAFP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAFP.Location = new System.Drawing.Point(265, 124);
            this.txtCodAFP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodAFP.Name = "txtCodAFP";
            this.txtCodAFP.Size = new System.Drawing.Size(252, 25);
            this.txtCodAFP.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido materno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(5, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código de AFP:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoPaterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(265, 34);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(252, 25);
            this.txtApellidoPaterno.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(265, 94);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 25);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoMaterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(265, 64);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(252, 25);
            this.txtApellidoMaterno.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(5, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero de teléfono:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(5, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 29);
            this.label14.TabIndex = 13;
            this.label14.Text = "Código de seguro:";
            // 
            // txtDUI
            // 
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUI.Location = new System.Drawing.Point(265, 184);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(252, 25);
            this.txtDUI.TabIndex = 29;
            // 
            // btnMostrarDatosGenerales
            // 
            this.btnMostrarDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnMostrarDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatosGenerales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDatosGenerales.Image = global::Transportes_Figueroa.Properties.Resources.right_arrow;
            this.btnMostrarDatosGenerales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.btnMostrarDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarDatosGenerales.Name = "btnMostrarDatosGenerales";
            this.btnMostrarDatosGenerales.Size = new System.Drawing.Size(522, 27);
            this.btnMostrarDatosGenerales.TabIndex = 47;
            this.btnMostrarDatosGenerales.Text = "Datos generales";
            this.btnMostrarDatosGenerales.UseVisualStyleBackColor = false;
            this.btnMostrarDatosGenerales.Click += new System.EventHandler(this.btnMostrarDatosGenerales_Click);
            // 
            // EliminarEmpleado
            // 
            this.EliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.EliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.EliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarEmpleado.Location = new System.Drawing.Point(229, 443);
            this.EliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarEmpleado.Name = "EliminarEmpleado";
            this.EliminarEmpleado.Size = new System.Drawing.Size(88, 40);
            this.EliminarEmpleado.TabIndex = 67;
            this.EliminarEmpleado.Text = "Eliminar";
            this.EliminarEmpleado.UseVisualStyleBackColor = false;
            this.EliminarEmpleado.Click += new System.EventHandler(this.EliminarEmpleado_Click);
            // 
            // ActualizarEmpleado
            // 
            this.ActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.ActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.ActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarEmpleado.Location = new System.Drawing.Point(229, 398);
            this.ActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ActualizarEmpleado.Name = "ActualizarEmpleado";
            this.ActualizarEmpleado.Size = new System.Drawing.Size(88, 39);
            this.ActualizarEmpleado.TabIndex = 66;
            this.ActualizarEmpleado.Text = "Actualizar";
            this.ActualizarEmpleado.UseVisualStyleBackColor = false;
            this.ActualizarEmpleado.Click += new System.EventHandler(this.ActualizarEmpleado_Click);
            // 
            // AgregarEmpleado
            // 
            this.AgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.AgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEmpleado.Location = new System.Drawing.Point(229, 353);
            this.AgregarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarEmpleado.Name = "AgregarEmpleado";
            this.AgregarEmpleado.Size = new System.Drawing.Size(88, 38);
            this.AgregarEmpleado.TabIndex = 65;
            this.AgregarEmpleado.Text = "Agregar";
            this.AgregarEmpleado.UseVisualStyleBackColor = false;
            this.AgregarEmpleado.Click += new System.EventHandler(this.AgregarEmpleado_Click);
            // 
            // AdministrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 602);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.QuitarSeleccion);
            this.Controls.Add(this.MostrarTodosLosEmpleados);
            this.Controls.Add(this.AgregarFotoEmpleado);
            this.Controls.Add(this.FotoEmpleado);
            this.Controls.Add(this.ListaEmpleados);
            this.Controls.Add(this.FiltroPorRol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EliminarEmpleado);
            this.Controls.Add(this.ActualizarEmpleado);
            this.Controls.Add(this.AgregarEmpleado);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdministrarEmpleados";
            this.Text = "CreacionEmpleado";
            this.Load += new System.EventHandler(this.CreacionEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoEmpleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelDireccion.ResumeLayout(false);
            this.PanelDireccion.PerformLayout();
            this.PanelRol.ResumeLayout(false);
            this.PanelRol.PerformLayout();
            this.PanelDatosUsuario.ResumeLayout(false);
            this.PanelDatosUsuario.PerformLayout();
            this.PanelDatosGenerales.ResumeLayout(false);
            this.PanelDatosGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button QuitarSeleccion;
        private System.Windows.Forms.Button MostrarTodosLosEmpleados;
        private System.Windows.Forms.Button AgregarFotoEmpleado;
        private System.Windows.Forms.PictureBox FotoEmpleado;
        private System.Windows.Forms.ListView ListaEmpleados;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox FiltroPorRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel PanelDireccion;
        private System.Windows.Forms.TextBox txtCodCasa;
        private System.Windows.Forms.ComboBox ListaMunicipios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.ComboBox ListaDepartamentos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMostrarDireccion;
        private System.Windows.Forms.TableLayoutPanel PanelRol;
        private System.Windows.Forms.ComboBox ListaRolesEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMostrarRolEmpleado;
        private System.Windows.Forms.TableLayoutPanel PanelDatosUsuario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ListaRolesUsuario;
        private System.Windows.Forms.Button btnMostrarDatosUsuario;
        private System.Windows.Forms.TableLayoutPanel PanelDatosGenerales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCodSeguro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodAFP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnMostrarDatosGenerales;
        private System.Windows.Forms.Button EliminarEmpleado;
        private System.Windows.Forms.Button ActualizarEmpleado;
        private System.Windows.Forms.Button AgregarEmpleado;
    }
}