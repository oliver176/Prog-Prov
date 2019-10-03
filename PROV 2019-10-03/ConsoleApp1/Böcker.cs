using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Böcker
    {
        public float price;
        private string category;
        private int actualValue;
        private bool cursed;
        private int rarity;
        private string namn;
        private Random generator = new Random();

        public Böcker(string namnInput)
        {   
            // Skapar string listor
            List<string> namnLista = new List<string>(new string[] { "Flygande BOB", "Alexander Eken", "Sirdock", "Spaghettins återkomst" });
            List<string> categoryLista = new List<string>(new string[] { "Science Fiction", "Fantasy", "Romance", "Drama" });

            //Ger variablerna ett random namn/category
            namn = namnLista[generator.Next(namnLista.Count)];
            category = categoryLista[generator.Next(categoryLista.Count)];

            //namn = namnInput;     //om du ska sätta namn genom input
            actualValue = generator.Next(1, 100);
            rarity = generator.Next(1, 100);
            price = Evaluate();

            if (generator.Next(100) < 50) //50% av tiden
            {
                cursed = false;
            }
            else cursed = true;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Book name: " + namn);
            Console.WriteLine("Book rarity: " + rarity + "/100");
            Console.WriteLine("Book category: " + category);
            Console.WriteLine("Book price: " + price + "\n");
        }

        public float Evaluate()
        {
            float rättpris = (actualValue * rarity);

            rättpris *= (generator.Next(50, 150) / 100); //blir fel pga int används, byter till float

            return rättpris;

            //  Sedan slumpas värdet som ska returneras mellan 50% och 150% av "rätt pris".
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return namn;
        }

        public bool IsCursed()
        {
            if (generator.Next(100) < 80) //80% av tiden
            {
                return cursed;
            }

            cursed = !cursed; //flippa boolen
            return cursed;
        }
    }
}