using System;

/*
 clase Cosa
*-*-*-*-*-*-
(-) entero:int
(-) cadena:string
(-) fecha:DateTime
*-*-*-*-*-*-*-*-*-*-*
(+) EstablecerValor(int):void
(+) EstablecerValor(string):void
(+) EstablecerValor(DateTime):void
*-*-*-*-*-*-*-*-*-*
(-) Mostrar():string -> de instancia
(+) Mostrar(Cosa):string -> de clase
*-*-*-*-*-*-*
 */
namespace Clase04.Sobrecarga
{
    class Program
    {
      
        
        //Mostrar valores de los atributos

        static void Main(string[] args)
        {
            //Crear una instancia de 'Cosa'
            Cosa cosa1 = new Cosa();

            //Establecer valor a sus atributos
            cosa1.EstablecerValor(1);
            cosa1.EstablecerValor("Cadena cosa1");
            cosa1.EstablecerValor(DateTime.Now);
        }
    }
}
