using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WebApi.Data
{
    public class DBCone
    {private String cadena;
        public DBCone() {
            cadena = "Data Source=ALEX\\ALEX;Initial Catalog=PruebaWebApi;Integrated Security=True";


        }

        public string Cadena { get => cadena; set => cadena = value; }

        /*validar la conexion*/

        public Boolean validarConexion() {

            SqlConnection cone = new SqlConnection(cadena);

            try
            {
                cone.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally {
                cone.Close();
            }
        }
    }
}
