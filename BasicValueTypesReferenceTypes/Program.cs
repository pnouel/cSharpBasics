using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicValueTypesReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types son primitivos, estos usan para guardar la variable y el valor
            //el mismo espacio de memoria 
            //asi que no se modifica implicitamente . Se copia
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("{0} {1}",a,b));

            var array1 = new int[3] { 2, 3, 4 };
            var array2 = array1;
            array2[0] = 0;
            //Reference types son no primitivos, guarda el valor en heap
            // y localiza la variable con la ubiacion del valor en heap
            //el valor se modifica segun la indicacion de la varible
            Console.WriteLine(string.Format("{0} {1}",array1[0],array2[0]));

            //Metodos estaticos pueden ser accesados sin instanciar un objeto
        }
    }
}
