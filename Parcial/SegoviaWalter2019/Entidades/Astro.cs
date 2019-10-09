using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        /// <summary>
        /// Mostrar() es un método protegido que devuelve toda la información del astro. (Ej: Nombre: {nombre} -
        /// Órbita: {órbita } -Rotación: {rotación})
        /// </summary>
        /// <returns></returns>
        protected string Mostar()
        {
            string cad = String.Format("Nombre: {0}-Orbita:{1}-Rotacion:{2}", this.nombre, this.duracionOrbita, this.duracionRotacion);
            return cad;
        }

        /// <summary>
        /// Orbitar() método abstracto.
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();

        /// <summary>
        /// Rotar() método virtual que retorna el mensaje "Rotando. Tiempo estimado: {tiempo de rotación}."
        /// </summary>
        /// <returns></returns>
        public virtual string Rotar()
        {
            return ("Tempo estimado:" + this.duracionRotacion);
        }

        /// <summary>
        /// Agregar un conversor explícito de Astro a String que retorne sólo el nombre del astro.
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator string(Astro a)
        {
            return a.nombre;
        }
    }
}
