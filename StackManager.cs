using System;
using System.Collections.Generic;

namespace vecka4ArrY
{
    internal class StackManager
    {
        // Stack fungerar enligt LIFO: sist in, först ut
        Stack<string> texter = new Stack<string>();
        public void Start()
        {
            bool kör = true;

            while (kör)
            {
                Console.WriteLine("=== TEXT OCH ÅNGRA ===");
                Console.WriteLine("1. Lägg till text");
                Console.WriteLine("2. Ångra");
                Console.WriteLine("3. Visa text");
                Console.WriteLine("4. Avsluta");

                Console.Write("Välj: ");
                string val = Console.ReadLine();

                if (val == "1")
                {
                    LäggTillText();
                }

                if (val == "2")
                {
                    Ångra();
                }

                if (val == "3")
                {
                    VisaText();
                }

                if (val == "4")
                {
                    kör = false;
                }
            }
        }


        public void LäggTillText()
        {
            Console.Write("Skriv text: ");
            string text = Console.ReadLine();

            // Push lägger texten överst i stacken
            texter.Push(text);
        }

        public void Ångra()
        {
            if (texter.Count > 0)
            {
                // Pop tar bort den senast tillagda texten
                string borttagen = texter.Pop();

                Console.WriteLine($"Ångrade: {borttagen}");
            }
            else
            {
                Console.WriteLine("Det finns ingen text att ångra.");
            }
        }

        public void VisaText()
        {
            if (texter.Count == 0)
            {
                Console.WriteLine("Det finns ingen text.");
                return;
            }

            // Visar texten från senast tillagd till först tillagd
            foreach (string text in texter)
            {
                Console.WriteLine(text);
            }
        }
    }
}
