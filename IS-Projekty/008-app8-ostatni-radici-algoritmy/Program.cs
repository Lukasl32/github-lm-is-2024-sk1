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

    private static void SelectionSort(int[] array)
    {
        int temp, min;
        for (int i = 0; i < (array.Length - 1); i++)
        {
            min = array.Length - 1;
            // hledání minima
            for (int j = i; j < (array.Length - 1); j++)
                if (array[min] > array[j])
                    min = j;
            // prohození prvku
            temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
    }

    private static void InsertionSort(int[] array)
    {
        int item, j;
        for (int i = 1; i <= (array.Length - 1); i++)
        {
            // ulozeni prvku
            item = array[i];
            j = i - 1;
            while ((j >= 0) && (array[j] > item))
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = item;
        }
    }

    private static void ShakerSort(int[] array)
    {
        bool swapped;
        for (int i = 0; i < array.Length / 2; i++)
        {
            swapped = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] < array[j + 1])
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]); // přímé prohození prvků
                    swapped = true;
                }
            }
            for (int j = 0; j < array.Length - 2 - i; j++)
            {
                if (array[j] > array[j - 1])
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    private static void CombSort<T>(T[] array)
    {

    }

    private static void ShellSort<T>(T[] array)
    {

    }
}
