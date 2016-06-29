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
    public class DetalleOrdenRepo
    {
        public void cargar_detalle_orden(DetalleOrden detalle_orden)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                dominio.Add(detalle_orden);
                dominio.SaveChanges();
            }
        }

    }
}
