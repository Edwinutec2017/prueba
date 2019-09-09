using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Respuesta
    {

        private String mensaje;
        public Respuesta(String msg) {
            this.Mensaje = msg;
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
