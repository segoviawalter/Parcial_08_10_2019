using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get { return this.satelites; }
        }

        /// <summary>
        /// Sobre carga del == (Planeta, Planeta) compara dos planetas por el nombre
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="planeta2"></param>
        /// <returns></returns>
        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            return (String.Equals(planeta.nombre, planeta2.nombre));
        }

        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        /// <summary>
        /// Sobre carga del == (Planeta, Satélite) que chequea si el satélite se encuentra en la lista (comparando el
        /// nombre).
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator ==(Planeta planeta,Satelite satelite)
        {
            foreach (Astro item in planeta.satelites)
            {
                if (String.Equals(item, satelite))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// String.Equals(item, satelite)
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
        { }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }

        /// <summary>
        /// Orbitar() retorna el siguiente mensaje "Orbita el planeta: {nombre}"
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return "Orbita el planeta:"+base.nombre;
        }

        /// <summary>
        /// Sobrecarga el operador + para agregar un satélite a la lista, como recibe un objeto del tipo Astro debe validar
        /// que sea satélite y no planeta.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator +(Planeta planeta,Satelite satelite)
        {
            foreach (Astro item in planeta.satelites)
            {
                if(item is Satelite && !(planeta==satelite))
                {
                    planeta.satelites.Add(satelite);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Rotar() método que no sobreescribe el base. Retorna: "Orbita el planeta {nombre}"
        /// </summary>
        /// <returns></returns>
        public new string Rotar()
        {
            return this.nombre;
        }

        /// <summary>
        /// Sobrecarga del ToString() que retorna la información del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.Mostar();
        }
    }
}
