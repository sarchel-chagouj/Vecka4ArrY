using System;
using System.Collections.Generic;

namespace vecka4ArrY
{
    internal class GradeManager
    {
        Dictionary<string, int> betyg = new Dictionary<string, int>();
        public void Start()
        {
            bool kör = true;

            while (kör)
            {
                Console.WriteLine("=== STUDENTBETYG ===");
                Console.WriteLine("1. Lägg till elev");
                Console.WriteLine("2. Visa alla elever");
                Console.WriteLine("3. Uppdatera betyg");
                Console.WriteLine("4. Visa medelbetyg");
                Console.WriteLine("5. Avsluta");

                Console.Write("Välj: ");
                string val = Console.ReadLine();

                if (val == "1")
                {
                    LäggTillElev();
                }

                if (val == "2")
                {
                    VisaAllaElever();
                }

                if (val == "3")
                {
                    UppdateraBetyg();
                }

                if (val == "4")
                {
                    VisaMedelbetyg();
                }

                if (val == "5")
                {
                    kör = false;
                }
            }
        }


        public void LäggTillElev()
        {
            Console.Write("Elevens namn: ");
            string namn = Console.ReadLine();

            if (betyg.ContainsKey(namn))
            {
                Console.WriteLine("Eleven finns redan.");
                return;
            }

            Console.Write("Betyg: ");
            int betygsVärde = int.Parse(Console.ReadLine());

            betyg.Add(namn, betygsVärde);
        }

        public void VisaAllaElever()
        {
            foreach (var elev in betyg)
            {
                Console.WriteLine($"Elev: {elev.Key}, Betyg: {elev.Value}");
            }
        }

        public void UppdateraBetyg()
        {
            Console.Write("Elevens namn: ");
            string namn = Console.ReadLine();

            if (betyg.ContainsKey(namn))
            {
                Console.Write("Nytt betyg: ");
                int nyttBetyg = int.Parse(Console.ReadLine());

                betyg[namn] = nyttBetyg;
            }
            else
            {
                Console.WriteLine("Eleven finns inte.");
            }
        }

        public void VisaMedelbetyg()
        {
            int summa = 0;

            foreach (var elev in betyg)
            {
                summa += elev.Value;
            }

            double medel = (double)summa / betyg.Count;

            Console.WriteLine($"Medelbetyg: {medel}");
        }
    }
}
