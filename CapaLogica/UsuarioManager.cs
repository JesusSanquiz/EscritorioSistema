using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CapaLogica
{
    public class UsuarioManager
    {
        public static Usuario ObtenerUsuarioPorCorreoYContrasena(string correo, string contrasena)
        {
            using (BBDD_LoginEntities db = new BBDD_LoginEntities())
            {
                var usuarioDatos = db.Usuario
                    .Include("Estado_Usuario")
                    .FirstOrDefault(u => u.Correo_Electronico == correo);

                if (usuarioDatos != null && usuarioDatos.Contrasena == contrasena && usuarioDatos.Id_Estado == 1) // Se Verifica que el usuario esté activo
                {
                    // Se reestablece  el contador de intentos fallidos
                    usuarioDatos.Intento_Login_Fallido = 0;

                    // Realiza una conversión explícita o crea un nuevo objeto CapaLogica.Usuario
                    Usuario usuarioLogica = new Usuario
                    {
                        Rut_Usuario = (int)usuarioDatos.Rut_Usuario,
                        Primer_Nombre = usuarioDatos.Primer_Nombre,
                        Segundo_Nombre = usuarioDatos.Segundo_Nombre,
                        Apellido_Paterno = usuarioDatos.Apellido_Paterno,
                        Apellido_Materno = usuarioDatos.Apellido_Materno,
                        Correo_Electronico = usuarioDatos.Correo_Electronico,
                        Contrasena = usuarioDatos.Contrasena,
                        Intento_Login_Fallido = (int)usuarioDatos.Intento_Login_Fallido,
                        Id_Estado = (int)usuarioDatos.Id_Estado,
                        Fecha_Creacion = usuarioDatos.Fecha_Creacion ?? DateTime.MinValue,
                        Fecha_Modificacion = usuarioDatos.Fecha_Modificacion ?? DateTime.MinValue
                 
                    };

                    return usuarioLogica;
                }
                else
                {
                    // Incrementa el contador de intentos fallidos
                    if (usuarioDatos != null)
                    {
                        usuarioDatos.Intento_Login_Fallido++;

                        // Se Bloquea al usuario después del tercer intento fallido
                        if (usuarioDatos.Intento_Login_Fallido >= 3)
                        {
                            usuarioDatos.Id_Estado = 3; // Se Asigna el estado de usuario bloqueado (3)
                        }
                    }

                    // Se Guarda los cambios en la base de datos
                    db.SaveChanges();

                    return null;
                }
            }
        }
    }
}

