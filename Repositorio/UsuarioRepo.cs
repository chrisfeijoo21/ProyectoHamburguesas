using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Repositorio
{
    public class UsuarioRepo
    {
        public void cargar_usuario(Usuario usuario)
        {
            using(entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(usuario);
                dominio.SaveChanges();
            }
        }
        public void actualizar_usuario(Usuario usuario)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.AttachCopy(usuario);
                dominio.SaveChanges();
            }
        }
        public IEnumerable<Usuario> mostrar_usuarios()
        {
            using(entidadDominio dominio = new entidadDominio())
            {
                IEnumerable<Usuario> listaUsuario = dominio.Usuarios.ToList();
                return dominio.CreateDetachedCopy(listaUsuario);
            }
        }
        public Usuario validar_usuario(string usuario, string password)
        {
            Usuario usuario_temp = null;
            using (entidadDominio dominio = new entidadDominio())
            {
                usuario_temp = dominio.Usuarios.Where(c => c.Username == usuario && c.Password == password).FirstOrDefault();
                return usuario_temp;
            }
        }
        public Usuario ListaUsuariosPorID(int id_usuario)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                Usuario usuario = dominio.Usuarios.Where(c => c.Id_usuario == id_usuario).FirstOrDefault();
                return usuario;
            }
        }
        public void eliminar_usuario(Usuario usuario)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Delete(usuario); //no anda
                dominio.SaveChanges();
            }
        }
    }
}
