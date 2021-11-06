using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Television:Electrodomestico ,Imostrar
    {
        public void mostrar()
        {
            precioFinal(resolucion, sintonizador);
        }
        private int resolucion;
        private bool sintonizador;

        protected int Resolucion { get => resolucion; set => resolucion = value; }
        protected bool Sintonizador { get => sintonizador; set => sintonizador = value; }

        public Television()
        {

        }
        public Television(int precio, int peso)
        {
            this.PrecioBase = precio;
            this.Peso = peso;
        }
        public Television(string color, int precioBase, string consumoEnergetico, int peso, int resolucion, bool sintonizador)
    : base(color, precioBase, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
            //precioFinal(resolucion, sintonizador);
        }
        public void precioFinal(int resolucion, bool sintonizador)
        {
            if (resolucion > 40)
            {
                PrecioBase = PrecioBase + (PrecioBase * 0.3);
            }
            if (sintonizador == true)
            {
                PrecioBase = PrecioBase + (PrecioBase * 0.5);
            }
            Console.WriteLine("El precio final es: $" + PrecioBase);
        }

    }
}
