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
    public class SubRubroNego
    {
        SubRubroRepo subRubroRepo = new SubRubroRepo();

        public void cargar_subrubro(Subrubro subrubro)
        {
            subRubroRepo.cargar_subrubro(subrubro);
        }
        public void actualizar_subrubro(Subrubro subrubro)
        {
            subRubroRepo.actualizar_subrubro(subrubro);
        }
        public IEnumerable<Subrubro> mostrar_subrubros(int id)
        {
            return subRubroRepo.mostrar_subrubros(id);
        }
        public void eliminar_subrubro(Subrubro subrubro)
        {
            subRubroRepo.eliminar_subrubro(subrubro);
        }
    }
}
