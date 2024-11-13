using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace _008_app8_ostatni_radici_algoritmy;

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
            int[] output, arrayBackup;
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
            arrayBackup = output.ToArray();

            Console.WriteLine("\nNáhodná čísla: ");
            PrintArray<int>(output);
            Console.WriteLine();

            // ------------
            Stopwatch watch;

            int selection;
            Console.Write("Vyberte algoritmus co chcete aplikovat (celé číslo): ");
            Console.WriteLine("1 - Selection sort");
            Console.WriteLine("2 - Insertion sort");
            Console.WriteLine("3 - Shaker sort");
            Console.WriteLine("4 - Comb sort");
            Console.WriteLine("5 - Shall sort");
            while (!int.TryParse(Console.ReadLine(), out selection))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            watch = Stopwatch.StartNew();
            switch (selection)
            {
                case 1:
                    SelectionSort(output);
                    break;
                case 2:
                    InsertionSort(output);
                    break;
                case 3:
                    ShakerSort(output);
                    break;
                case 4:
                    CombSort(output);
                    break;
                case 5:
                    ShellSort(output);
                    break;
                default:
                    break;
            }
            watch.Stop();

            Console.WriteLine("\nPole po otočení:");
            PrintArray<int>(output);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[Doba zpracování: {watch.Elapsed}]");
            Console.ResetColor();

            Console.ReadKey();
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

    private static void SelectionSort<T>(T[] array)
    {
        
    }

    private static void InsertionSort<T>(T[] array)
    {

    }

    private static void ShakerSort<T>(T[] array)
    {

    }

    private static void CombSort<T>(T[] array)
    {

    }

    private static void ShellSort<T>(T[] array)
    {

    }
}
