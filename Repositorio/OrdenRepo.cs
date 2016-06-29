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
    public class OrdenRepo
    {
        public void cargar_orden(Orden orden)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(orden);
                dominio.SaveChanges();
            }
        }
    }
}
