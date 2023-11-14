namespace Transportes_Figueroa.views
{
    partial class AdministrarRolesEmpleados
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
            this.EliminarRolEmpleado = new System.Windows.Forms.Button();
            this.ActualizarRolEmpleado = new System.Windows.Forms.Button();
            this.AgregarRolEmpleado = new System.Windows.Forms.Button();
            this.DataGridRolesEmpleados = new System.Windows.Forms.DataGridView();
            this.IDAccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRolSueldo = new System.Windows.Forms.NumericUpDown();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRolesEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRolSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarRolEmpleado
            // 
            this.EliminarRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.EliminarRolEmpleado.FlatAppearance.BorderSize = 0;
            this.EliminarRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRolEmpleado.Location = new System.Drawing.Point(231, 216);
            this.EliminarRolEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarRolEmpleado.Name = "EliminarRolEmpleado";
            this.EliminarRolEmpleado.Size = new System.Drawing.Size(88, 31);
            this.EliminarRolEmpleado.TabIndex = 5;
            this.EliminarRolEmpleado.Text = "Eliminar";
            this.EliminarRolEmpleado.UseVisualStyleBackColor = false;
            this.EliminarRolEmpleado.Click += new System.EventHandler(this.EliminarRolEmpleado_Click);
            // 
            // ActualizarRolEmpleado
            // 
            this.ActualizarRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.ActualizarRolEmpleado.FlatAppearance.BorderSize = 0;
            this.ActualizarRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarRolEmpleado.Location = new System.Drawing.Point(135, 216);
            this.ActualizarRolEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ActualizarRolEmpleado.Name = "ActualizarRolEmpleado";
            this.ActualizarRolEmpleado.Size = new System.Drawing.Size(88, 31);
            this.ActualizarRolEmpleado.TabIndex = 4;
            this.ActualizarRolEmpleado.Text = "Actualizar";
            this.ActualizarRolEmpleado.UseVisualStyleBackColor = false;
            this.ActualizarRolEmpleado.Click += new System.EventHandler(this.ActualizarRolEmpleado_Click);
            // 
            // AgregarRolEmpleado
            // 
            this.AgregarRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.AgregarRolEmpleado.FlatAppearance.BorderSize = 0;
            this.AgregarRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarRolEmpleado.Location = new System.Drawing.Point(41, 216);
            this.AgregarRolEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgregarRolEmpleado.Name = "AgregarRolEmpleado";
            this.AgregarRolEmpleado.Size = new System.Drawing.Size(88, 31);
            this.AgregarRolEmpleado.TabIndex = 3;
            this.AgregarRolEmpleado.Text = "Agregar";
            this.AgregarRolEmpleado.UseVisualStyleBackColor = false;
            this.AgregarRolEmpleado.Click += new System.EventHandler(this.AgregarRolEmpleado_Click);
            // 
            // DataGridRolesEmpleados
            // 
            this.DataGridRolesEmpleados.AllowUserToAddRows = false;
            this.DataGridRolesEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(190)))));
            this.DataGridRolesEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridRolesEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRolesEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAccion,
            this.IDRol,
            this.RolEmpleado,
            this.SalarioEmpleado});
            this.DataGridRolesEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridRolesEmpleados.Location = new System.Drawing.Point(326, 107);
            this.DataGridRolesEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridRolesEmpleados.Name = "DataGridRolesEmpleados";
            this.DataGridRolesEmpleados.Size = new System.Drawing.Size(694, 427);
            this.DataGridRolesEmpleados.TabIndex = 12;
            this.DataGridRolesEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridRolesEmpleados_CellContentClick);
            // 
            // IDAccion
            // 
            this.IDAccion.HeaderText = "#";
            this.IDAccion.Name = "IDAccion";
            // 
            // IDRol
            // 
            this.IDRol.DataPropertyName = "id_rol";
            this.IDRol.HeaderText = "ID";
            this.IDRol.Name = "IDRol";
            // 
            // RolEmpleado
            // 
            this.RolEmpleado.DataPropertyName = "rol";
            this.RolEmpleado.HeaderText = "Rol";
            this.RolEmpleado.Name = "RolEmpleado";
            this.RolEmpleado.Width = 250;
            // 
            // SalarioEmpleado
            // 
            this.SalarioEmpleado.DataPropertyName = "sueldo_hora";
            this.SalarioEmpleado.HeaderText = "Sueldo por hora";
            this.SalarioEmpleado.Name = "SalarioEmpleado";
            this.SalarioEmpleado.Width = 200;
            // 
            // txtRolSueldo
            // 
            this.txtRolSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRolSueldo.DecimalPlaces = 2;
            this.txtRolSueldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolSueldo.Location = new System.Drawing.Point(41, 186);
            this.txtRolSueldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRolSueldo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtRolSueldo.Name = "txtRolSueldo";
            this.txtRolSueldo.Size = new System.Drawing.Size(278, 25);
            this.txtRolSueldo.TabIndex = 2;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(41, 126);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(277, 25);
            this.txtNombreRol.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 167);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "Salario: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 107);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Rol de empleado:";
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Location = new System.Drawing.Point(1073, 14);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(88, 31);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnQuitarSeleccion
            // 
            this.btnQuitarSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.btnQuitarSeleccion.FlatAppearance.BorderSize = 0;
            this.btnQuitarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarSeleccion.Location = new System.Drawing.Point(40, 253);
            this.btnQuitarSeleccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            this.btnQuitarSeleccion.Size = new System.Drawing.Size(154, 31);
            this.btnQuitarSeleccion.TabIndex = 13;
            this.btnQuitarSeleccion.Text = "Limpiar";
            this.btnQuitarSeleccion.UseVisualStyleBackColor = false;
            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
            // 
            // AdministrarRolesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 610);
            this.Controls.Add(this.btnQuitarSeleccion);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.EliminarRolEmpleado);
            this.Controls.Add(this.ActualizarRolEmpleado);
            this.Controls.Add(this.AgregarRolEmpleado);
            this.Controls.Add(this.DataGridRolesEmpleados);
            this.Controls.Add(this.txtRolSueldo);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdministrarRolesEmpleados";
            this.Text = "AdministrarRolesEmpleados";
            this.Load += new System.EventHandler(this.AdministrarRolesEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRolesEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRolSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarRolEmpleado;
        private System.Windows.Forms.Button ActualizarRolEmpleado;
        private System.Windows.Forms.Button AgregarRolEmpleado;
        private System.Windows.Forms.DataGridView DataGridRolesEmpleados;
        private System.Windows.Forms.NumericUpDown txtRolSueldo;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IDAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioEmpleado;
        private System.Windows.Forms.Button btnQuitarSeleccion;
    }
}