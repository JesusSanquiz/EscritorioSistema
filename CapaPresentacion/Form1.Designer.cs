namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IniciarSesion = new System.Windows.Forms.Label();
            this.CorreoElectronico = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.RecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.AutoSize = true;
            this.IniciarSesion.Location = new System.Drawing.Point(191, 30);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(70, 13);
            this.IniciarSesion.TabIndex = 0;
            this.IniciarSesion.Text = "Iniciar Sesión";
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.AutoSize = true;
            this.CorreoElectronico.Location = new System.Drawing.Point(77, 102);
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Size = new System.Drawing.Size(94, 13);
            this.CorreoElectronico.TabIndex = 1;
            this.CorreoElectronico.Text = "Correo Electrónico";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.Location = new System.Drawing.Point(77, 148);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(61, 13);
            this.Contrasena.TabIndex = 2;
            this.Contrasena.Text = "Contraseña";
            // 
            // RecuperarContrasena
            // 
            this.RecuperarContrasena.AutoSize = true;
            this.RecuperarContrasena.Location = new System.Drawing.Point(191, 186);
            this.RecuperarContrasena.Name = "RecuperarContrasena";
            this.RecuperarContrasena.Size = new System.Drawing.Size(114, 13);
            this.RecuperarContrasena.TabIndex = 3;
            this.RecuperarContrasena.TabStop = true;
            this.RecuperarContrasena.Text = "Recuperar Contraseña";
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(194, 224);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(441, 2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(20, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "X";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(181, 95);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(141, 20);
            this.textBoxCorreoElectronico.TabIndex = 6;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(181, 145);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(141, 20);
            this.textBoxContrasena.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 286);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.RecuperarContrasena);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.CorreoElectronico);
            this.Controls.Add(this.IniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IniciarSesion;
        private System.Windows.Forms.Label CorreoElectronico;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.LinkLabel RecuperarContrasena;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.TextBox textBoxContrasena;
    }
}

