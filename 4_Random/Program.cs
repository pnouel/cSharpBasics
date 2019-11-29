using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Random
{
    class Program
    {
        static void Main(string[] args)
        {


            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>
            /// 
            var intento =0;
           

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese un numero :\n Ha intentado {0} veces", intento);
                var numero = new Random().Next(0, 10);
                var input = Convert.ToInt32(Console.ReadLine());
                if (numero == input)
                {
                    Console.WriteLine("Ganaste");
                    return;
                }
                Console.WriteLine("Perdiste"); ;
                intento++;
            }
           
        }
    }
}
