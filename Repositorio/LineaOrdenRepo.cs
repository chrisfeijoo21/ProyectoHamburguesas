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
    public class LineaOrdenRepo
    {
        public void cargar_linea_orden(LineaOrden linea_orden)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(linea_orden);
                dominio.SaveChanges();
            }
        }
    }
}
