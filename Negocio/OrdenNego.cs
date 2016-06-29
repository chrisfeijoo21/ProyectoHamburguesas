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
    public class OrdenNego
    {
        OrdenRepo ordenRepo = new OrdenRepo();

        public void cargar_orden(Orden orden)
        {
            ordenRepo.cargar_orden(orden);
        }
    }
}
