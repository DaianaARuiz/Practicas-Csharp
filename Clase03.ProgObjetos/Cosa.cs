using System;
using System.Collections.Generic;
using System.Text;

namespace Clase04.Sobrecarga
{
    class Cosa
    {
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
        private int entero;
        private string cadena;
        private DateTime fecha;

        public void EstablecerValor(int n) 
        {
            this.entero = n;
        }

        public void EstablecerValor(string s)
        {
            this.cadena = s;
        }

        public void EstablecerValor(DateTime f)
        {
            this.fecha = f;
        }

        private static string Mostrar()
        {
            //return string.Format("{0},{1},{2}", this.entero, this.cadena, this.fecha);
        }
        public static string Mostrar()
        {
            return
        }
    }
}
