using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,3));
            } 
           

        }
    }
}
