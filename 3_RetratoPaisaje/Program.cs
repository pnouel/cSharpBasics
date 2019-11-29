using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RetratoPaisaje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program and ask the user to enter the width and height of an image. 
             Then tell if the image is landscape or portrait.
             */
            /*
            Console.WriteLine("Ingrese el Ancho:");
            var ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Alto:");
            var alto = Convert.ToInt32(Console.ReadLine());
            var resultado = (ancho == alto) ? "Es un cuadrado" : (ancho > alto) ? "Es Paisaje" : "Es Retrato";
            Console.WriteLine(resultado);
            */
            //Opcion 2

            Console.WriteLine("Ingrese el Ancho:");
            var ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Alto:");
            var alto = Convert.ToInt32(Console.ReadLine());
            var resultado = (ancho == alto) ? "Es " + Orientacion.cuadrado : 
                (ancho > alto) ? "Es " + Orientacion.paisaje : "Es " +  Orientacion.retrato;
            Console.WriteLine(resultado);
        }
        public enum Orientacion
        {
            cuadrado,
            paisaje,
            retrato
        }
    }

}


