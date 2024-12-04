namespace _003c_app3c_obrazce;

internal class Program
{
    static void Main(string[] args)
    {
        string? again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********** Obrazce ************");
            Console.WriteLine("********************************");
            Console.WriteLine("******** Lukáš Moravec *********");

            /* 
             * Hlavní menu pomocí switch
             * Funkce na jednotlivé obrazce
             * Otázka na opakování
             */
            int size;
            Console.Write("\nZadejte velikost, ve které budete chtít vypsat obrazec: ");
            while (!int.TryParse(Console.ReadLine(), out size))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            Console.WriteLine("\nJaký obrazec chcete vykreslit?");
            Console.WriteLine("1 - Obrazec 1 (podle zadání (4))");
            Console.WriteLine("2 - Obrazec 2 (podle zadání (19))");
            Console.WriteLine("3 - Obrazec 3 (podle zadání (12))");
            Console.WriteLine("------------");
            Console.Write("Volba: ");

            int selection;
            bool repeat = false;
            do
            {
                repeat = false;
                if (!int.TryParse(Console.ReadLine(), out selection))
                    selection = 0;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\n Obrazec 1 (podle zadání (4))");
                        Console.WriteLine("-------------------------------\n");
                        Shape01(size);
                        break;
                    case 2:
                        if (size % 2 != 0)
                            size++;
                        Console.WriteLine($"\n Obrazec 2 (podle zadání (19)) [pro toto zadání dojde ke změně velikosti na sudé číslo (size={size})]");
                        Console.WriteLine("-------------------------------\n");
                        Shape02(size);
                        break;
                    case 3:
                        Console.WriteLine("\n Obrazec 3 (podle zadání (12))");
                        Console.WriteLine("-------------------------------\n");
                        Shape03(size);
                        break;
                    default:
                        repeat = true;
                        Console.Write("Neplatná volba!! \nZadejte znovu: ");
                        break;
                }
            } while (repeat);
            Console.ReadKey();
        }
    }

    private static void Shape01(int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                // top & bottom row
                if (row == 0 || row == size - 1)
                    Console.Write("* ");

                // diagonal line
                else if (col == row)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }

    private static void Shape02(int size)
    {
        int start = 0;
        int end = size - 1;
        bool decrease = true;

        for (int row = 0; row < size; row++)
        {
            if (row < size / 2)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col >= start && col <= end)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                if (row + 1 != size / 2)
                {
                    start++;
                    end--;
                }
            }
            else
            {
                for (int col = 0; col < size; col++)
                {
                    if (col >= start && col <= end)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                start--;
                end++;
            }

            Console.WriteLine();
        }
    }
    private static void Shape03(int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((row + col) % 2 == 0)
                    Console.Write("  ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
