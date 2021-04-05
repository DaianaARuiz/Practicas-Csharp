using System;

namespace Clase02_EjercicioSello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sello";

            Sello.mensaje = "Hola mundooo";
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "hola mundo0000000000 C#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.ArmarFormatoMensaje());
        }
    }
}
