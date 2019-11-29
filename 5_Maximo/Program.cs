using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Maximo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 5 numeros separados por comas");
            var input = Console.ReadLine();
            var numeros = input.Split(',');
           // int[] cosa = Convert.ToInt32(numeros);
            int max = cosa.Max();
            int p = Array.IndexOf(cosa, max);
            Console.WriteLine(p);

        }
           //No salio

        }
    }

