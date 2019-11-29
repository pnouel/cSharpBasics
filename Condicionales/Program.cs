using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF IF ELSE operador ternario
            int hour = 20;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("its mornig");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("its noche");
            }

            //bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.99f;

            //}
            //else
            //{
            //    price = 22.99f;
            //}
            //operador ternario
            float price2 = (isGoldCustomer) ? 19.99f : 22.99f;

        }
    }
}
