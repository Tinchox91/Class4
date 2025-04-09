using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4Interfaces.Interfaces;
namespace Clase4Interfaces.Clases
{
    public class Perro : Animal ,  ICaminar, INadar, IReptar
    {

        private string raza;
        private string pelaje;
        public Perro(string raza, string pelaje)
        {
            this.raza = raza;
            this.pelaje = pelaje;
        }
        public Perro()
        {
        }
        public Perro(string nombre, double tamanio, double peso) : base(nombre, tamanio, peso)
        {
        }


        public void caminar()
        {
            Random rand = new Random();
            int metros = rand.Next(1, 100);
            Console.WriteLine($"El perro {nombre} camino {metros} metros");
        }

        public void nadar()
        {
            Random rand = new Random();
            int metros = rand.Next(1, 100);
            Console.WriteLine($"El perro {nombre} nado {metros} metros");
        }

        public void reptar()
        {
            Random rand = new Random();
            int metros = rand.Next(1, 100);
            Console.WriteLine($"El perro {nombre} reptó {metros} metros");
        }

        protected override void mostrarDatos()
        {
            Console.WriteLine($"Perro: {nombre} , Tamaño: {tamanio} , Peso {peso}, Raza: {raza}, Pelaje: ´{pelaje}");
        }
    }
}
