using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;
using System.Data;

namespace Negocio
{
    public class UsuarioNego
    {
        UsuarioRepo usuarioRepo = new UsuarioRepo();

        public void CargaUsuario(Usuario usuario)
        {
            usuarioRepo.CargaUsuario(usuario);
        }
        public IEnumerable<Usuario> MostrarUsuario()
        {
            return usuarioRepo.MostrarUsuario();
        }

        public DataTable CompararUsuario(string idUser, string Usuario, string password)
        {
            return usuarioRepo.CompararUsuario(idUser,Usuario,password);
        }
    }
}
