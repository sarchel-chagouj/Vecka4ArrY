namespace vecka4ArrY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många tal vill du ange? ");

            int antal = int.Parse(Console.ReadLine());

            int[] tal = new int[antal];

            // Mata in talen
            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write($"Ange tal {i + 1}: ");
                tal[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dina tal:");

            // Skriv ut talen
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }

            int summa = 0;

            // Räkna ut summan
            for (int i = 0; i < tal.Length; i++)
            {
                summa += tal[i];
            }

            Console.WriteLine($"Summa: {summa}");

            double medelvärde = (double)summa / tal.Length;
            Console.WriteLine($"Medelvärde: {medelvärde}");

            BookManager manager = new BookManager();
            manager.Start();

            GradeManager gradeManager = new GradeManager();
            gradeManager.Start();

            StackManager stackManager = new StackManager();
            stackManager.Start();






        }
    }
}
