using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicEnum
{
    //Conjuno de constantes clave Valor
    //Comienzaen posicin 0 y suma 1 a la posiciondel siguiente
    public enum ShippingMehod {
           RegularAirMail = 1,
           RegisterdAirMail = 2,
           Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMehod.RegisterdAirMail;

            Console.WriteLine((int)method);

            //Recibiendo el valor Casteamos a la clave 

            var metod = 2;
            Console.WriteLine((ShippingMehod)(metod));

            //Convert to o string
       ;
            Console.WriteLine(method.ToString());

            //convert sring to shippingMehod
            //PARSEAR de un tipo a  otro

            var methodParse = "Express";
            //Variable es de tipo enum. ver doc Parse TYPE type usar ypeof
            var shipping = (ShippingMehod)Enum.Parse(typeof(ShippingMehod), methodParse);

           
        }
    }
}
