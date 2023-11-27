using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("1. oyuncu ismini gir");

            string oyuncu1 = Console.ReadLine();

            Console.WriteLine("2. oyuncu imsini gir");

            string oyuncu2 = Console.ReadLine();

            int OyuncuRound = 0;
            

            while (true)
            {
                int zar = random.Next(1, 20);
                
                int zar2 = random.Next(1,20);


                Console.WriteLine($"{oyuncu1} zar atmak icin bir tusa bas");

                Console.ReadKey();

                Console.WriteLine($"{oyuncu1} zar sonucunuz {zar}");

                Console.WriteLine($"{oyuncu2} zar atmak icin bir tusa bas");

                Console.ReadKey();

                Console.WriteLine($"{oyuncu2} zar sonucunuz {zar2}");

                if (zar > zar2)
                {
                    OyuncuRound++;
                    Console.WriteLine($"Tebrikler {oyuncu1} {OyuncuRound}. roundu kazandınız");
                    Console.WriteLine("Oyun devam edilsin mi?");
                    
                }
                else if (zar2 > zar)
                {
                    OyuncuRound++;
                    Console.WriteLine($"Tebrikler {oyuncu2} {OyuncuRound}. roundu kazandınız");
                    Console.WriteLine("Oyun devam edilsin mi?");

                }
                else if (zar == zar2)
                {
                    Console.WriteLine("Berabere Tekrar Zar atın");
                }

                if (Console.ReadLine() == "Hayır")
                {
                    
                    break;
                }
            }
        }
        
        
    }
}
