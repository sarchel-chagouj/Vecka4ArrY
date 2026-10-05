using System;
using System.Collections.Generic;

namespace vecka4ArrY
{
    internal class QueueManager
    {
        // Queue fungerar enligt FIFO: först in, först ut
        Queue<string> uppgifter = new Queue<string>();

        public void LäggTillUppgift()
        {
            Console.Write("Skriv en uppgift: ");
            string uppgift = Console.ReadLine();

            // Lägger uppgiften sist i kön
            uppgifter.Enqueue(uppgift);
        }

        public void VisaNästaUppgift()
        {
            if (uppgifter.Count > 0)
            {
                // Peek visar första uppgiften utan att ta bort den
                Console.WriteLine($"Nästa uppgift: {uppgifter.Peek()}");
            }
            else
            {
                Console.WriteLine("Det finns inga uppgifter.");
            }
        }

        public void SlutförUppgift()
        {
            if (uppgifter.Count > 0)
            {
                // Dequeue tar bort och returnerar första uppgiften
                string klar = uppgifter.Dequeue();

                Console.WriteLine($"Slutförd uppgift: {klar}");
            }
            else
            {
                Console.WriteLine("Det finns inga uppgifter.");
            }
        }

        public void VisaAllaUppgifter()
        {
            if (uppgifter.Count == 0)
            {
                Console.WriteLine("Det finns inga uppgifter.");
                return;
            }

            // Går igenom alla uppgifter som finns kvar
            foreach (string uppgift in uppgifter)
            {
                Console.WriteLine(uppgift);
            }
        }
    }
}
