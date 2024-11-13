namespace _009_app9_otoceni_pole;

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

            int count, min, max;
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;
            int evenCount = 0, oddCount = 0;
            int[] output;
            Random random = new();

            Console.Write("Zadejte počet čísel k vygenerování N (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            do
            {
                if (!valid)
                    Console.WriteLine("\n!!! Spodní mez musí být menší než horní mez !!!\n");

                Console.Write("Zadejte dolní mez (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out min))
                    Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

                Console.Write("Zadejte horní mez (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out max))
                    Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

                valid = min < max;
            }
            while (!valid);

            output = new int[count];
            Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, max, min);

            for (int i = 0; i < count; i++)
                output[i] = random.Next(min, max);

            Console.WriteLine("\nNáhodná čísla: ");
            PrintArray<int>(output);
            Console.WriteLine();

            // ------------
            var watch = System.Diagnostics.Stopwatch.StartNew();
            ArrayReverse(output);
            watch.Stop();

            Console.WriteLine("\nPole po otočení:");
            PrintArray<int>(output);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[Doba zpracování: {watch.Elapsed}]");
            Console.ResetColor();

            Console.ReadKey();
        }
    }

    private static void ArrayReverse<T>(T[] array)
    {
        T temp;
        for (int i = 0; i < array.Length / 2; i++)
        {
            temp = array[i];
            array[i] = array[array.Length - 1 - i]; //^1 je stejné jako array.Lenght-1
            array[array.Length - 1 - i] = temp;
        }
    }

    private static void PrintArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0) Console.Write("[{0}; ", array[i]);
            else if (i == array.Length - 1) Console.WriteLine("{0}]", array[i]);
            else Console.Write("{0}; ", array[i]);
        }
    }
}
