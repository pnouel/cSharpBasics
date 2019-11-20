using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Secuence de caracteres  SCAPING CHARACTERS
            //Asignar con string literal
            // concatenar con + o string.format placeholder {0}{1} 
            //sting.join("1,", miArray)
            //index [] para acceder a caracteresindividuales
            //Inmutble usa metodos para hacer un nuevo sting
            //Espacio \n nueva linea \t ta \\backslash \' single \" double
            //verbatim Strings
            //sring path = @"c:\project\proyectSub";
            string firstName = "Petro";
            var primerNombre = "Petros";
            //Podemosusar la clase para crear la variale
            String lastName = "Nouel";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("my name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Marta", "Carla" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hola, esto es una forma
de escribir de forma literal.
Lo que queremos escribir.

c:\directorio\directorio";
            Console.WriteLine(text);
        }
    }
}
