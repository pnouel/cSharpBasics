﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_NumeroValido
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1- Write a program and ask the user to enter a number. 
             The number should be between 1 to 10. If the user enters a valid number,
             display "Valid" on the console. Otherwise, display "Invalid". 
             (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/

            //Solucion 1
            int  number = 0;
           /* if (number >= 1 && number <= 10 )
            {
                Console.WriteLine("The number is VALID");
            }
            else
            {
                Console.WriteLine("The number is INVALID");
            }
            */

            //Solucion 2
            /*
            var validacion = (number >= 1 && number <= 10) ? " The number is valid" : "The number is ivalid";
            Console.WriteLine(validacion);
            */

            //Solucion 3
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }


           


        }
    }
}
