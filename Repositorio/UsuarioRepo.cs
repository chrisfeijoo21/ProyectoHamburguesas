using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Repositorio
{
    public class UsuarioRepo
    {
        public void CargaUsuario(Usuario usuario)
        {
            using(entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(usuario);
                dominio.SaveChanges();
            }
        }

        public IEnumerable<Usuario> MostrarUsuario()
        {
            using(entidadDominio dominio = new entidadDominio())
            {
                IEnumerable<Usuario> listaUsuario = dominio.Usuarios.ToList();
                return dominio.CreateDetachedCopy(listaUsuario);
            }
        }

        public DataTable CompararUsuario(string idUser, string Usuario, string password)
        {
            DataTable dt = new DataTable();
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = SoftwareComandas; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string query = "select * from usuario where idUsuario='" + idUser + "' and Usuario='" + Usuario + "' and Contraseña='" + password + "';";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
