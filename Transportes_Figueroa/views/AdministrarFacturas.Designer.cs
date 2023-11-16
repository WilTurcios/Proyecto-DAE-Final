namespace Transportes_Figueroa.views
{
    partial class AdministrarFacturas
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
            this.DataGridFaccturas = new System.Windows.Forms.DataGridView();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.IDAccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaccturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridFaccturas
            // 
            this.DataGridFaccturas.AllowUserToAddRows = false;
            this.DataGridFaccturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridFaccturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridFaccturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFaccturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccion});
            this.DataGridFaccturas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridFaccturas.Location = new System.Drawing.Point(208, 101);
            this.DataGridFaccturas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DataGridFaccturas.Name = "DataGridFaccturas";
            this.DataGridFaccturas.Size = new System.Drawing.Size(746, 432);
            this.DataGridFaccturas.TabIndex = 13;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.btnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFactura.Location = new System.Drawing.Point(29, 119);
            this.btnEliminarFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(88, 31);
            this.btnEliminarFactura.TabIndex = 18;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.UseVisualStyleBackColor = false;
            this.btnEliminarFactura.Click += new System.EventHandler(this.btnEliminarFactura_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(921, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 31);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // IDAccion
            // 
            this.IDAccion.HeaderText = "#";
            this.IDAccion.Name = "IDAccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Seleccione la factura a eliminar";
            // 
            // AdministrarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.DataGridFaccturas);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdministrarFacturas";
            this.Text = "AdministrarFacturas";
            this.Load += new System.EventHandler(this.AdministrarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaccturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridFaccturas;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccion;
        private System.Windows.Forms.Label label1;
    }
}