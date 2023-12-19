using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Ingresar_Click_1(object sender, EventArgs e)
        {
            string correo = textBoxCorreoElectronico.Text;
            string contrasena = Encrypt.GetSHA256(textBoxContrasena.Text.Trim());

            using (BBDD_LoginEntities db = new BBDD_LoginEntities())
            {
                // Se obtiene el usuario por correo y contraseña
                var usuario = UsuarioManager.ObtenerUsuarioPorCorreoYContrasena(correo, contrasena);

                if (usuario != null)
                {
                    MessageBox.Show("Usuario Existe");

                }
                else
                {
                    MessageBox.Show("Usuario No existe");

                    // Se Verifica si el usuario está bloqueado
                    var usuarioBloqueado = db.Usuario
                        .FirstOrDefault(u => u.Correo_Electronico == correo);

                    if (usuarioBloqueado != null && usuarioBloqueado.Id_Estado == 3)
                    {
                        MessageBox.Show("Usuario bloqueado. Contacte al administrador.");
                    }
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
