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
    public class LineaOrdenNego
    {
        LineaOrdenRepo lineaOrdenRepo = new LineaOrdenRepo();

        public void cargar_linea_orden(LineaOrden linea_orden)
        {
            lineaOrdenRepo.cargar_linea_orden(linea_orden);
        }
    }
}
