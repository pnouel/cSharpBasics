using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_LimiteVelocidad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Your job is to write a program for a speed camera. 
             For simplicity, ignore the details such as camera, sensors, etc and focus 
             purely on the logic. Write a program that asks the user to enter the speed limit. 
             Once set, the program asks for the speed of a car. If the user enters a value less than 
             the speed limit, program should display Ok on the console. If the value is above the speed limit, 
             the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 
             1 demerit points should be incurred and displayed on the console. If the number of demerit points 
             is above 12, the program should display License Suspended.
             */

            Console.WriteLine("Ingrese limite de velocidad: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese  velocidad del auto: ");
            var speed = Convert.ToInt32(Console.ReadLine());
           
            if (speedLimit > speed)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int demeritosPorKMS = 5;
                var speedDif = (speed - speedLimit)/demeritosPorKMS;
                var resultadoDemeritos = (speedDif > 12) ? "LICENCIA CANCELADA" : "Se Suman " + speedDif + " Demeritos ";
                Console.WriteLine(resultadoDemeritos);
            }

        }
    }
}
