using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    abstract class Electrodomestico
    {
        private string color;
        private double precioBase = 0;
        private string consumoEnergetico;
        private int peso;


        public Electrodomestico()
        {
        }
        public Electrodomestico(double precio, int peso)
        {
            this.precioBase = precio;
            this.peso = peso;

        }
        public Electrodomestico(string color, int precio, string consumo, int peso)
        {
            this.color = color;
            this.precioBase = precio;
            this.consumoEnergetico = consumo;
            this.peso = peso;
            comprobarColor(color);
            comprobarConsumoEnergetico(consumo);
            precioFinal(consumo, peso);

        }

        protected string Color { get => color; set => color = value; }
        protected double PrecioBase { get => precioBase; set => precioBase = value; }
        protected string ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }
        protected int Peso { get => peso; set => peso = value; }

        protected void comprobarConsumoEnergetico(string consumo)
        {
            string[] consumoE = new string[5] { "a", "b", "c", "d", "e" };
            for (int i = 0; i < consumoE.Length; i++)
            {
                if (consumo == consumoE[i])
                {
                    Console.WriteLine("El consumo es valido");
                    this.consumoEnergetico = consumo;
                }

            }
        }
        protected void comprobarColor(string color)
        {
            string[] colores = new string[5] { "blanco", "gris", "negro", "rojo", "azul" };
            for (int i = 0; i < colores.Length; i++)
            {
                if (color == colores[i])
                {
                    Console.WriteLine("El color es correcto");
                    this.color = color;
                }
            }
        }

        public void precioFinal(string consumo, int peso)
        {
            if (consumoEnergetico == "a")
            {
                precioBase = 100;
            }
            if (consumoEnergetico == "b")
            {
                precioBase = 80;
            }
            if (consumoEnergetico == "c")
            {
                precioBase = 60;
            }
            if (consumoEnergetico == "d")
            {
                precioBase = 50;
            }
            if (consumoEnergetico == "e")
            {
                precioBase = 30;
            }
            if (consumoEnergetico == "f")
            {
                precioBase = 10;
            }
            if (peso >= 0 && peso <= 19)
            {
                precioBase = precioBase + 30;
            }
            if (peso >= 20 && peso <= 49)
            {
                precioBase = precioBase + 50;
            }
            if (peso >= 50 && peso <= 79)
            {
                precioBase = precioBase + 80;
            }
            if (peso >= 80)
            {
                precioBase = precioBase + 100;
            }


        }
    }
}
