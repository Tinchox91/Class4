using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4Interfaces.Clases
{
   public abstract class Animal
    {
        protected string nombre { get; set; }
        protected double tamanio { get; set; }
        protected double peso { get; set; }

        protected Animal(string nombre, double tamanio, double peso)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
            this.peso = peso;
        }

        protected Animal()
        {
        }
        protected abstract void mostrarDatos();
    }
}
