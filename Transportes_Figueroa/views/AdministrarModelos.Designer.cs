namespace Transportes_Figueroa.views
{
    partial class AdministrarModelos
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EliminarModelo = new System.Windows.Forms.Button();
            this.AgregarModelo = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ListaMarcas_modelos = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGridModelos = new System.Windows.Forms.DataGridView();
            this.IDAccionAgregarModelo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EliminarModelo);
            this.groupBox6.Controls.Add(this.AgregarModelo);
            this.groupBox6.Location = new System.Drawing.Point(22, 188);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(244, 70);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Acciones";
            // 
            // EliminarModelo
            // 
            this.EliminarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.EliminarModelo.FlatAppearance.BorderSize = 0;
            this.EliminarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarModelo.Location = new System.Drawing.Point(125, 22);
            this.EliminarModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarModelo.Name = "EliminarModelo";
            this.EliminarModelo.Size = new System.Drawing.Size(111, 35);
            this.EliminarModelo.TabIndex = 4;
            this.EliminarModelo.Text = "Eliminar";
            this.EliminarModelo.UseVisualStyleBackColor = false;
            this.EliminarModelo.Click += new System.EventHandler(this.EliminarModelo_Click);
            // 
            // AgregarModelo
            // 
            this.AgregarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarModelo.FlatAppearance.BorderSize = 0;
            this.AgregarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarModelo.Location = new System.Drawing.Point(7, 22);
            this.AgregarModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarModelo.Name = "AgregarModelo";
            this.AgregarModelo.Size = new System.Drawing.Size(111, 35);
            this.AgregarModelo.TabIndex = 3;
            this.AgregarModelo.Text = "Agregar";
            this.AgregarModelo.UseVisualStyleBackColor = false;
            this.AgregarModelo.Click += new System.EventHandler(this.AgregarModelo_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.ListaMarcas_modelos);
            this.groupBox7.Controls.Add(this.txtModelo);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(22, 45);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(244, 126);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Información general";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Marca:";
            // 
            // ListaMarcas_modelos
            // 
            this.ListaMarcas_modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaMarcas_modelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListaMarcas_modelos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMarcas_modelos.FormattingEnabled = true;
            this.ListaMarcas_modelos.Location = new System.Drawing.Point(10, 90);
            this.ListaMarcas_modelos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaMarcas_modelos.Name = "ListaMarcas_modelos";
            this.ListaMarcas_modelos.Size = new System.Drawing.Size(219, 25);
            this.ListaMarcas_modelos.TabIndex = 2;
            this.ListaMarcas_modelos.SelectedIndexChanged += new System.EventHandler(this.ListaMarcas_modelos_SelectedIndexChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(10, 37);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(219, 25);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Modelo:";
            // 
            // DataGridModelos
            // 
            this.DataGridModelos.AllowUserToAddRows = false;
            this.DataGridModelos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridModelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionAgregarModelo});
            this.DataGridModelos.Location = new System.Drawing.Point(285, 46);
            this.DataGridModelos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridModelos.Name = "DataGridModelos";
            this.DataGridModelos.Size = new System.Drawing.Size(786, 516);
            this.DataGridModelos.TabIndex = 6;
            // 
            // IDAccionAgregarModelo
            // 
            this.IDAccionAgregarModelo.HeaderText = "#";
            this.IDAccionAgregarModelo.Name = "IDAccionAgregarModelo";
            this.IDAccionAgregarModelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDAccionAgregarModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(983, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 27);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AdministrarModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 576);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.DataGridModelos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdministrarModelos";
            this.Text = "AdministrarModelos";
            this.Load += new System.EventHandler(this.AdministrarModelos_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridModelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button EliminarModelo;
        private System.Windows.Forms.Button AgregarModelo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ListaMarcas_modelos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridModelos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionAgregarModelo;
        private System.Windows.Forms.Button btnCerrar;
    }
}