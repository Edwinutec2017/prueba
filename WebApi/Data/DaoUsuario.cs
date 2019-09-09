using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WebApi.Data
{

    public class DaoUsuario
    {
        private String cadena;
        private SqlConnection cone;
        private SqlCommand cmd;
        private List<Models.ModelUsuario> lista;

        public List<Models.ModelUsuario> mostrarTodos() {
            lista = new List<Models.ModelUsuario>();
            lista = generLista("execute selectUsuarios");
            if (lista!=null) {
                return lista;
            }
            else {
                return null;
            }


        }

        public List<Models.ModelUsuario> mostrarId(int id)
        {
            lista = new List<Models.ModelUsuario>();
            lista = generLista("execute selectId "+id+"");
            if (lista != null)
            {
                return lista;
            }
            else
            {
                return null;
            }


        }




        /*genmerico para mostrar datos*/
        public List<Models.ModelUsuario> generLista(String sql) {
            DBCone conexion = new DBCone();
            if (conexion.validarConexion()) {
                cone = new SqlConnection(conexion.Cadena);
                cmd = new SqlCommand(sql,cone);
                lista = new List<Models.ModelUsuario>();
                try
                {
                    cone.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            lista.Add(new Models.ModelUsuario(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetDateTime(3)));
                        }
                        return lista;
                    }
                    else {
                        return null;
                    }
                }
                catch
                {
                    return null;

                }
                finally {
                    cone.Close();
                }
            }
            else {
                return null;
            }
        }



    }
}
