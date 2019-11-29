using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MaximoDeDos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              Write a program which takes two numbers from the console and displays the maximum of the two.
             */

            Console.WriteLine("Ingrese el primer numero");
            var numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero");
            var numeroDos = Convert.ToInt32(Console.ReadLine());
            var maximo = Math.Max(numeroDos, numeroUno);
            Console.WriteLine($"El mayor es {maximo}");
                

            Console.WriteLine("Ingresar Primer Numero");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar Segundo Numero");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            var maximo2 = (numero1==numero2)?"Son iguales":numero1 > numero2 ?"El mayor es "+ numero1: "El mayor es " + numero2;
            Console.WriteLine(maximo);

        }
    }
}
