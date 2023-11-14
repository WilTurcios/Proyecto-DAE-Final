namespace Transportes_Figueroa.views
{
    partial class AdministrarMarcas
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EliminarMarca = new System.Windows.Forms.Button();
            this.AgregarMarca = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridMarcas = new System.Windows.Forms.DataGridView();
            this.IDAccionAgregarMarca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EliminarMarca);
            this.groupBox5.Controls.Add(this.AgregarMarca);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(19, 125);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(244, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // EliminarMarca
            // 
            this.EliminarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.EliminarMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.EliminarMarca.FlatAppearance.BorderSize = 0;
            this.EliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMarca.Location = new System.Drawing.Point(125, 22);
            this.EliminarMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarMarca.Name = "EliminarMarca";
            this.EliminarMarca.Size = new System.Drawing.Size(111, 37);
            this.EliminarMarca.TabIndex = 3;
            this.EliminarMarca.Text = "Eliminar";
            this.EliminarMarca.UseVisualStyleBackColor = false;
            this.EliminarMarca.Click += new System.EventHandler(this.EliminarMarca_Click);
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.AgregarMarca.FlatAppearance.BorderSize = 0;
            this.AgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMarca.Location = new System.Drawing.Point(7, 22);
            this.AgregarMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(111, 37);
            this.AgregarMarca.TabIndex = 2;
            this.AgregarMarca.Text = "Agregar";
            this.AgregarMarca.UseVisualStyleBackColor = false;
            this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMarca);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(19, 45);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(244, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información general";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(10, 37);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(219, 25);
            this.txtMarca.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre:";
            // 
            // DataGridMarcas
            // 
            this.DataGridMarcas.AllowUserToAddRows = false;
            this.DataGridMarcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccionAgregarMarca});
            this.DataGridMarcas.Location = new System.Drawing.Point(281, 46);
            this.DataGridMarcas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridMarcas.Name = "DataGridMarcas";
            this.DataGridMarcas.Size = new System.Drawing.Size(783, 173);
            this.DataGridMarcas.TabIndex = 3;
            // 
            // IDAccionAgregarMarca
            // 
            this.IDAccionAgregarMarca.HeaderText = "#";
            this.IDAccionAgregarMarca.Name = "IDAccionAgregarMarca";
            this.IDAccionAgregarMarca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDAccionAgregarMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(976, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 27);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AdministrarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 519);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DataGridMarcas);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdministrarMarcas";
            this.Text = "AdministrarMarcas";
            this.Load += new System.EventHandler(this.AdministrarMarcas_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button EliminarMarca;
        private System.Windows.Forms.Button AgregarMarca;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridMarcas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccionAgregarMarca;
        private System.Windows.Forms.Button btnCerrar;
    }
}