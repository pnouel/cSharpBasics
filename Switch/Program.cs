using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Seasons.Summer;

            /*switch (season)
            {
                case Seasons.Spring:
                    //Interpolacion de Strings 
                    Console.WriteLine($"Its {season} and is a beautiful season");
                    break;
                case Seasons.Summer:
                    Console.WriteLine(season);
                    break;
                case Seasons.Winter:
                    Console.WriteLine(season);
                    break;
                case Seasons.Autum:
                    Console.WriteLine(season);
                    break;
                default:
                    break;
                    */
                    //Si queremos usar la respuesta para mas de una condicon esta es la sintaxis


                    switch (season)
                    {
                        case Seasons.Spring:                        
                        case Seasons.Summer:
                            Console.WriteLine($"Its {season} and is a beautiful season");
                            break;
                        case Seasons.Winter:
                            Console.WriteLine(season);
                            break;
                        case Seasons.Autum:
                            Console.WriteLine(season);
                            break;
                        default:
                            break;
                    }
            }
        }
    }

