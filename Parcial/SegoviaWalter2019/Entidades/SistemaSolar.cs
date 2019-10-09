using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SistemaSolar:
//20. Planetas: atributo privado del tipo List<Astros>.
//21. Posee un solo constructor sin parámetros.
//22. MostrarInformacionAstros(): método que retorna toda la información de los planetas, y sus satélites.
namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planetas
        {
            get { return this.planetas; }
        }

        public string MostarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Astro item in planetas)
            {
                if(item is Planeta)
                sb.AppendLine("Planeta"+((Planeta)item).ToString());

                else
                {
                    sb.AppendLine("Satelite:" + ((Satelite)item).Nombre);
                  
                }
            }

            return sb.ToString();
        }

        private SistemaSolar()
        {
            planetas = new List<Astro>();
        }
    }
}
