using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class UsuarioNego
    {
        UsuarioRepo usuarioRepo = new UsuarioRepo();

        public void cargar_usuario(Usuario usuario)
        {
            usuarioRepo.cargar_usuario(usuario);
        }
        public void actualizar_usuario(Usuario usuario)
        {
            usuarioRepo.actualizar_usuario(usuario);
        }
        public IEnumerable<Usuario> mostrar_usuarios()
        {
            return usuarioRepo.mostrar_usuarios();
        }
        public Usuario validar_usuario(string usuario, string password)
        {
            return usuarioRepo.validar_usuario(usuario, password);
        }
        public Usuario ListaUsuariosPorID(int id_usuario)
        {
            return usuarioRepo.ListaUsuariosPorID(id_usuario);
        }
        public void eliminar_usuario(Usuario u)
        {
            usuarioRepo.eliminar_usuario(u);
        }
    }
}