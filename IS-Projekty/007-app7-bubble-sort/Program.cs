namespace _007_app7_bubble_sort;

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
            BubbleSort(output);
            watch.Stop();

            Console.WriteLine("\nPole po seřazení:");
            PrintArray<int>(output);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[Doba zpracování: {watch.Elapsed}]");
            Console.ResetColor();

            Console.ReadKey();
        }
    }

    private static void BubbleSort(int[] array, bool descending = true)
    {
        int compares = 0, changes = 0;
        int temp;
        Console.Write("Řazení... ");

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                compares++;
                if (descending)
                {
                    if (array[j] < array[j + 1]) // seřazení sestupně
                    {
                        changes++;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        /* // prohození bez pomocné proměnné
                        array[j] = array[j] + array[j+1];
                        array[j+1] = array[j] - array[j+1];
                        array[j] = array[j] - array[j+1];
                        */
                    }
                }
                else
                {
                    if (array[j] > array[j + 1]) // seřazení vzestupně
                    {
                        changes++;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        /* // prohození bez pomocné proměnné
                        array[j] = array[j] + array[j+1];
                        array[j+1] = array[j] - array[j+1];
                        array[j] = array[j] - array[j+1];
                        */
                    }
                }

            }
        }
        Console.WriteLine($"(bylo provedeno {compares} porovnání a {changes} změn)");
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
