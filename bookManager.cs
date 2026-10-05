using System;
using System.Collections.Generic;

namespace vecka4ArrY
{
    internal class BookManager
    {
        List<Book> böcker = new List<Book>();

        public void Start()
        {
            bool kör = true;

            while (kör)
            {
                Console.WriteLine("=== BOKHANTERARE ===");
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Visa alla böcker");
                Console.WriteLine("3. Sök efter bok");
                Console.WriteLine("4. Avsluta");

                Console.Write("Välj: ");
                string val = Console.ReadLine();

                if (val == "1")
                {
                    LäggTillBok();
                }

                if (val == "2")
                {
                    VisaAllaBöcker();
                }

                if (val == "3")
                {
                    SökEfterBok();
                }

                if (val == "4")
                {
                    kör = false;
                }
            }
        }

        public void LäggTillBok()
        {
            Book bok = new Book();

            Console.Write("Titel: ");
            bok.Titel = Console.ReadLine();

            Console.Write("Författare: ");
            bok.Författare = Console.ReadLine();

            Console.Write("År: ");
            bok.YearPublished = int.Parse(Console.ReadLine());

            böcker.Add(bok);
        }

        public void VisaAllaBöcker()
        {
            foreach (Book bok in böcker)
            {
                Console.WriteLine($"Titel: {bok.Titel}");
                Console.WriteLine($"Författare: {bok.Författare}");
                Console.WriteLine($"År: {bok.YearPublished}");
            }
        }

        public void SökEfterBok()
        {
            Console.Write("Sök efter titel: ");
            string sökning = Console.ReadLine();

            foreach (Book bok in böcker)
            {
                if (bok.Titel.ToLower() == sökning.ToLower())
                {
                    Console.WriteLine($"Titel: {bok.Titel}");
                    Console.WriteLine($"Författare: {bok.Författare}");
                    Console.WriteLine($"År: {bok.YearPublished}");
                }
            }
        }
    }
}
