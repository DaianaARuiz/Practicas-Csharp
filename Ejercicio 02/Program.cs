using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        /*
            Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
            mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
        */
        static void Main(string[] args)
        {
            Console.Title = "Usando Math";
            string numero;
            int cuadrado;
            int cubo;

            Console.WriteLine("Ingrese un numero: ");
            numero = Console.ReadLine();

            while( int.Parse(numero) <= 0)
            {
                Console.WriteLine("Numero incorrecto. Reingrese un numero: ");
                numero = Console.ReadLine();
            }
           

            //Utilizar metodos de la clase Math
            Console.WriteLine(Math.Pow(int.Parse(numero), 2));
            Console.WriteLine(Math.Pow(int.Parse(numero), 3));

            Console.ReadKey();
        }
    }
}
