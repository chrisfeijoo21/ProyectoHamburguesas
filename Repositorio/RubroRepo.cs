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
    public class RubroRepo
    {
        public void cargar_rubro(Rubro rubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(rubro);
                dominio.SaveChanges();
            }
        }
        public void actualizar_rubro(Rubro rubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.AttachCopy(rubro);
                dominio.SaveChanges();
            }
        }
        public IEnumerable<Rubro> mostrar_rubros()
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                IEnumerable<Rubro> listaRubro = dominio.Rubros.ToList();
                return dominio.CreateDetachedCopy(listaRubro);
            }
        }
        public void eliminar_rubro(Rubro rubro)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Delete(rubro); //no anda?
                dominio.SaveChanges();
            }
        }
    }
}
