using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicClasses.clases;

namespace basicClasses
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "john";
            john.LastName = "Smith";
            john.Introduce();

            Calculadora calculadore = new Calculadora();
            var result = calculadore.Add(2, 3);
            Console.WriteLine(result);
            /* Recibe dos parametro, se accede al metodo a traves de la 
             clase, recordar guardar resultado en una variable
             */

            
        }
    }
}
