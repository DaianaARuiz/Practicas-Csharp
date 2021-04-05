using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mi primer app en c#";

            Console.WriteLine("Hola mundo");
            Console.WriteLine("en c#");

            Console.Clear();

            Console.WriteLine("Escriba nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre);
            Console.WriteLine("Su nombre es {0} y su sueldo {1}",nombre,30000);
            Console.ReadKey();
        }
    }
}
