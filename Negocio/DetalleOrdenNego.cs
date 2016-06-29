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
    public class DetalleOrdenNego
    {
        DetalleOrdenRepo detalleOrdenRepo = new DetalleOrdenRepo();

        public void cargar_detalle_orden(DetalleOrden orden)
        {
            detalleOrdenRepo.cargar_detalle_orden(orden);
        }

    }
}
