using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesEntregable
{
    public class Usuario
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public string apellido { get; set; }
        public string nombreusuario { get; set; }
        public string contrasenia { get; set; }
        public string mail { get; set; }

        public Usuario(string nombre, int id, string apellido, string nombreusuario, string contrasenia, string mail)
        {
            this.nombre = nombre;
            this.id = id;
            this.apellido = apellido;
            this.nombreusuario = nombreusuario;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }
    }
}
