using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class ComidaRepo
    {
        public  IEnumerable<Comida> MostrarComidaXTipo (int idTipoComida)
        {
            using (entidadDominio dominio = new entidadDominio())
            {
                IEnumerable<Comida> listacomida = dominio.Comidas.Where(c => c.TipoComida == idTipoComida).ToList();
                return listacomida;
                
            }
        }
    }
}
