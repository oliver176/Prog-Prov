using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bookList = new List<Böcker>();
            Console.WriteLine("Hur många böcker vill du skapa?");
            int.TryParse(Console.ReadLine(), out int antalBöcker);

            for (int i = 0; i < antalBöcker; i++)
            {
                Console.Clear();
                //Console.WriteLine("Namnge bok nummer: " + (i + 1));
                bookList.Add(new Böcker(""));
            }

            Console.WriteLine("Hur många kunder vill du skapa");
            int.TryParse(Console.ReadLine(), out int antalKunder);  //string till int

            Console.Clear();

            var kundList = new List<Kunder>(); //skapar Kund listan

            for (int i = 0; i < antalKunder; i++)
            {
                kundList.Add(new Kunder());  //Skapar "antalKunder" st nya kunder i listan
            }
            while (true)
            {
                var keyRead = Console.ReadKey(true).Key;
                Console.WriteLine("1: Inspektera böcker");

                if (keyRead == ConsoleKey.D1) //om du trycker tangenten "1"
                {
                    for (int i = 0; i < antalBöcker; i++)
                    {
                        bookList.ForEach(item => item.PrintInfo()); //printinfo för varje bok i listan
                        Console.ReadLine();
                    }
                }
                else if (keyRead == ConsoleKey.D2)
                {
                    
                    
                }
            }
            Console.ReadLine();
        }

        /* Spelaren värderar böcker och artefakter som hen köper in till butiken genom att titta på deras skick och sällsynthet.
         * (En korrekt värdering gör sedan att spelaren kan sätta rätt pris, och förhoppningsvis göra en vinst på senare försäljning.)
           Spelaren kan också försöka avgöra ifall varan har någon förbannelse över sig. Det ska finnas en risk att göra en felaktig bedömning.
           Böckerna kan tillhöra olika kategorier.*/
    }
}