using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SäähänSopivaOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna tämänhetkinen säätila (esim. ukkonen, lumisade, sade):");
            string weather = Console.ReadLine().ToLower();

            Console.WriteLine("Onko sää kova vai pieni? (kirjoita 'kova' tai 'pieni', jos sovellettavissa):");
            string intensity = Console.ReadLine().ToLower();

            Console.WriteLine("Aktiviteettiehdotus:");

            switch (weather)
            {
                case "ukkonen":
                    Console.WriteLine("- Elokuvailta pimeässä");
                    break;
                case "lumisade":
                    if (intensity == "kova")
                        Console.WriteLine("- Kokkaus / leivonta");
                    else if (intensity == "pieni")
                        Console.WriteLine("- Lumisota");
                    else
                        Console.WriteLine("- Lumenveisto tai rentoutuminen sisällä");
                    break;
                case "sade":
                    if (intensity == "kova")
                        Console.WriteLine("- Opiskelu");
                    else if (intensity == "pieni")
                        Console.WriteLine("- Lukeminen tai rentoutuminen sisällä");
                    else
                        Console.WriteLine("- Pelien pelaaminen tai askartelu");
                    break;
                default:
                    Console.WriteLine("- Ulkoilu, harrastus tai uuden oppiminen");
                    break;
            }

            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi.");
            Console.ReadKey();
        }
    }
}
