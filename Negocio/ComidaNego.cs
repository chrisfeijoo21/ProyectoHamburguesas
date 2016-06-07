using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ComidaNego
    {
        ComidaRepo comidaRepo = new ComidaRepo();

        public IEnumerable<Comida> MostrarComidaXTipo(int idTipoComida)
        {
            return comidaRepo.MostrarComidaXTipo(idTipoComida);
        }
    }
}
