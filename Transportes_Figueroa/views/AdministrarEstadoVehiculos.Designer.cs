namespace Transportes_Figueroa.views
{
    partial class AdministrarEstadoVehiculos
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
            this.IDAccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.ListaEstados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVehiculos
            // 
            this.DataGridVehiculos.AllowUserToAddRows = false;
            this.DataGridVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccion});
            this.DataGridVehiculos.Location = new System.Drawing.Point(10, 175);
            this.DataGridVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridVehiculos.Name = "DataGridVehiculos";
            this.DataGridVehiculos.Size = new System.Drawing.Size(917, 173);
            this.DataGridVehiculos.TabIndex = 28;
            // 
            // IDAccion
            // 
            this.IDAccion.HeaderText = "#";
            this.IDAccion.Name = "IDAccion";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.Location = new System.Drawing.Point(303, 133);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(146, 27);
            this.btnCambiarEstado.TabIndex = 29;
            this.btnCambiarEstado.Text = "Cambiar estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // ListaEstados
            // 
            this.ListaEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaEstados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaEstados.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaEstados.FormattingEnabled = true;
            this.ListaEstados.Items.AddRange(new object[] {
            "En reparación",
            "Disponible",
            "Ocupado"});
            this.ListaEstados.Location = new System.Drawing.Point(10, 135);
            this.ListaEstados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaEstados.Name = "ListaEstados";
            this.ListaEstados.Size = new System.Drawing.Size(267, 25);
            this.ListaEstados.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Seleccione el estado al que quiere cambiar el vehiculo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(844, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 27);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdministrarEstadoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ListaEstados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.DataGridVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarEstadoVehiculos";
            this.Text = "AdministrarEstadoVehiculos";
            this.Load += new System.EventHandler(this.AdministrarEstadoVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVehiculos;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.ComboBox ListaEstados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccion;
    }
}