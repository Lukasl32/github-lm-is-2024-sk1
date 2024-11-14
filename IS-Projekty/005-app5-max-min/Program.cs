namespace _005_app5_max_min;

internal class Program
{
    static void Main(string[] args)
    {
        string repeate = "a";
        bool valid = true;
        while (repeate.Equals("a"))
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("******** Lukáš Moravec *********");

            int count, minSet, maxSet;
            int min = int.MaxValue, max = int.MinValue;
            int minPos = -1, maxPos = -1;

            Console.Write("Zadejte počet čísel k vygenerování N (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            do
            {
                if (!valid)
                    Console.WriteLine("\n!!! Spodní mez musí být menší než horní mez !!!\n");

                Console.Write("Zadejte dolní mez (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out minSet))
                    Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

                Console.Write("Zadejte horní mez (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out maxSet))
                    Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

                valid = minSet < maxSet;
            }
            while (!valid);

            int[] output = new int[count];

            Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, maxSet, minSet);

            Random random = new Random();

            Console.WriteLine("\nNáhodná čísla: ");
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = random.Next(minSet, maxSet + 1);
                Console.Write(" {0} ", output[i]);

                if (output[i] < min)
                {
                    min = output[i];
                    minPos = i;
                }
                if (output[i] > max)
                {
                    max = output[i];
                    maxPos = i;
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nČíselná řada má takovéto vlastnosti: ");
            Console.WriteLine($"Nejmenší hodnota: {min}, na pozici: {minPos}");
            Console.WriteLine($"Nejvyšší hodnota: {max}, na pozici: {maxPos}");

            Console.ReadKey();
        }
    }
}
