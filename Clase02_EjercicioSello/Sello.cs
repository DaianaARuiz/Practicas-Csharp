using System;
using System.Collections.Generic;
using System.Text;

namespace Clase02_EjercicioSello
{
    class Sello
    {
        //Atributo:
        public static string mensaje;

        public static ConsoleColor color;



        //Metodos:
        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
        }

        public static string ArmarFormatoMensaje()
        {
            string auxString;
            int strLenght = Sello.mensaje.Length;

            if (strLenght > 0)
            {
                auxString = new string('*', strLenght + 2)+"\n";
                auxString += "*" + Sello.mensaje + "*" + "\n";
                auxString += new string('*',strLenght + 2) + "\n";
                return auxString;
            }

            return string.Empty; 
        }
    }
}
