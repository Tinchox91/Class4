using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4Interfaces.Interfaces;
namespace Clase4Interfaces.Clases
{
    public class Pato : Animal,IVolar,ICaminar, INadar,IReptar
    {
        private string color;
        private string espcie;

        public Pato(string color, string espcie)
        {
            this.color = color;
            this.espcie = espcie;
        }

        public Pato()
        {
        }

        public Pato(string nombre, double tamanio, double peso) : base(nombre, tamanio, peso)
        {
        }

        public void nadar()
        {
            Random rand = new Random();
            int metros = rand.Next(1, 100);
            Console.WriteLine($"El pato {nombre} nado {metros} metros");

        }
    
        public void caminar()
        {
            Random rand = new Random();
            int metros = rand.Next(1,50);
            Console.WriteLine($"El pato {nombre} camino {metros} metros");

        }

        public void Volar()
        {
            Random rand = new Random();
            int metros = rand.Next(1, 80);
            Console.WriteLine($"El pato {nombre} volo {metros} metros");
        }

        protected override void mostrarDatos()
        {
            Console.WriteLine($"Pato: {nombre} , Tamaño: {tamanio} , Peso {peso}, Color: {color} , especie: {espcie}");
        }

        public void reptar()
        {
            throw new NotImplementedException();
        }
    }
}
