using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite:Astro
    {

        public string Nombre
        {

            get { return base.nombre; }
        }

        /// <summary>
        /// Orbitar() retorna "Orbitar el satelite: {nombre}".
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return ("Orbitar Satelite: " + this.Nombre);
        }

        public Satelite(int duraOrbita,int duraRotacion,string nombre):base(duraOrbita,duraRotacion,nombre)
        { }
    }
}
