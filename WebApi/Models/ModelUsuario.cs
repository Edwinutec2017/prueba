using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ModelUsuario
    {
        private int id;
        private String nombre, apellido;
        private DateTime nacimiento;


        public ModelUsuario(int id,String nombr,String apelli,DateTime fecha) {
            this.Id = id;
            this.Nombre = nombr;
            this.Apellido = apelli;
            this.Nacimiento = fecha;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
    }
}
