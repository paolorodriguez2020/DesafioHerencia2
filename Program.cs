using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {

            Lavadora lavarropa = new Lavadora("blanco", 0, "a", 30, 5);
            Lavadora lavarropa2 = new Lavadora("blanco", 0, "b", 51, 5);
            Television televisor = new Television("negro", 0, "a", 30, 50, true);
            Lista listar = new Lista();
            listar.agregar(lavarropa);
            listar.agregar(lavarropa2);
            listar.agregar(televisor);
            listar.mostrartodo();

            Console.ReadKey();
        }
    }
}
