using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            var numeros = new int[3];
            numeros[0] = 1;
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);

            var flag = new bool[3];
            flag[0] = true;
            Console.WriteLine(flag[1]);

            //Inicializacion de objeto, llaves y valores por cada elemento del aray
            var names = new string[3] { "John", "Marta", "Daniel" };
            Console.WriteLine(names[0] + " " + names[2]);

            // si no hay nad en la posicion muestra valores por default segunt tipo
        }
    }
}
