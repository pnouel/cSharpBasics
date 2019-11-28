using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_IngresarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
             /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        /// 
       /* var contador = 0 ;
        for (var i = 0; i <= 100; i++)
			{
                if (i%3 == 0)
                   contador++;
	            
	}     
                    Console.WriteLine(contador);                
                    */
          /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        /// 
            var contador = 0;
            while (true)
	{
               Console.WriteLine("Ingrese un numero o para terminar ingrese \"ok\" ");
               var input = Console.ReadLine();
                if (input.ToLower()=="ok")
                    break;
                contador += Convert.ToInt32(input);

	}
             Console.WriteLine(contador);           
	
			}
        
    }
}
