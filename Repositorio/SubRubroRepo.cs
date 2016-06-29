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
    public class SubRubroRepo
    {
        public void cargar_subrubro(Subrubro subrubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(subrubro);
                dominio.SaveChanges();
            }
        }
        public void actualizar_subrubro(Subrubro subrubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.AttachCopy(subrubro);
                dominio.SaveChanges();
            }
        }
        public IEnumerable<Subrubro> mostrar_subrubros(int id)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                IEnumerable<Subrubro> listaSubrubro = dominio.Subrubros.Where(s => s.Id_rubro == id).ToList();
                return dominio.CreateDetachedCopy(listaSubrubro);
            }
        }
        public void eliminar_subrubro(Subrubro subrubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Delete(subrubro); //no anda?
                dominio.SaveChanges();
            }
        }
    }
}
