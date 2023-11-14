namespace Transportes_Figueroa.views
{
    partial class CambiarContrasenia
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
            this.txtContraseniaPrevia = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasenia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce tu contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva contraseña:";
            // 
            // txtContraseniaPrevia
            // 
            this.txtContraseniaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseniaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaPrevia.Location = new System.Drawing.Point(14, 29);
            this.txtContraseniaPrevia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseniaPrevia.Name = "txtContraseniaPrevia";
            this.txtContraseniaPrevia.PasswordChar = '*';
            this.txtContraseniaPrevia.Size = new System.Drawing.Size(303, 25);
            this.txtContraseniaPrevia.TabIndex = 2;
            // 
            // txtNuevaContrasenia
            // 
            this.txtNuevaContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaContrasenia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasenia.Location = new System.Drawing.Point(14, 110);
            this.txtNuevaContrasenia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            this.txtNuevaContrasenia.PasswordChar = '*';
            this.txtNuevaContrasenia.Size = new System.Drawing.Size(303, 25);
            this.txtNuevaContrasenia.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(135, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.Aceptar.FlatAppearance.BorderSize = 0;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Location = new System.Drawing.Point(230, 151);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(88, 27);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(227)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(230, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Comprobar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CambiarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 190);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNuevaContrasenia);
            this.Controls.Add(this.txtContraseniaPrevia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CambiarContrasenia";
            this.Text = "ConfirmarContrasenia";
            this.Load += new System.EventHandler(this.ConfirmarContrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseniaPrevia;
        private System.Windows.Forms.TextBox txtNuevaContrasenia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button2;
    }
}