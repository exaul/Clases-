using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola, " + nombre + "Bienvenida a tu primera clase");

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
