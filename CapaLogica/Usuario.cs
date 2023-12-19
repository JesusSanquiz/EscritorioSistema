using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Usuario
    {
        public int Rut_Usuario { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Correo_Electronico { get; set; }
        public string Contrasena { get; set; }
        public int Intento_Login_Fallido { get; set; }
        public int Rut_Empresa { get; set; }
        public int Id_Estado { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        
    }
}