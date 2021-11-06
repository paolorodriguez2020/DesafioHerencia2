using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Lavadora:Electrodomestico,Imostrar
    {
        private int carga = 5;
        public void mostrar()
        {
            Preciofinal();
        }

        public Lavadora()
        {
            this.carga = 5;
        }
        public Lavadora(int precio, int peso)
        {
            this.PrecioBase = precio;
            this.Peso = peso;
        }
        public Lavadora(string color, int precioBase, string consumoEnergetico, int peso, int carga)
            : base(color, precioBase, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        protected int Carga { get => carga; set => carga = value; }

        public void Preciofinal()
        {

            if (carga > 30)
            {

                PrecioBase = PrecioBase + 50;
                Console.WriteLine("El precio final es:" + PrecioBase);
            }
            else
            {
                Console.WriteLine("El precio final es:" + PrecioBase);
            }
        }
    }
}
