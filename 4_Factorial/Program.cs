using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

             /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 
        Console.WriteLine("Ingresar Dato");
             var input =Convert.ToInt32(Console.ReadLine());
             var factorial = 1;
           
            for (var i = 0; i <= input; i++)
			{
                factorial *= i;
                
			}
             Console.WriteLine("{0} es el Factorial de {1}", factorial,input);
            
           

           

        }
    }
}
