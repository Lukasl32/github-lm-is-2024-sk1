namespace _011_app11_intervaly;

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

            int intervalCount;
            int numberDifference;
            int[] intervalCounts; // pole obsahující počet číse v intervalech, intervaly jsou rozdelené rovnoměrně

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

            numberDifference = ((max * min) > 0 ? (max >= 0 ? (max - min) : (max - min) * -1) : (max >= 0 ? (max + (min * -1)) : (max - (min * -1))));

            Console.Write("Zadejte počet intervalů, do kterých chcete rozdělit (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out intervalCount))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            intervalCounts = new int[numberDifference];

            int[] output = new int[count];

            Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, max, min);

            Random random = new();

            Console.WriteLine("\nNáhodná čísla: ");
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = random.Next(min, max + 1);
            }

            Console.WriteLine("Počet čísel v intervalu <{}-{}>: ");
            Console.WriteLine("Počet čísel v intervalu <{}-{}>: ");
            Console.WriteLine("Počet čísel v intervalu <{}-{}>: ");
            Console.WriteLine("Počet čísel v intervalu <{}-{}>: ");

            Console.ReadKey();
        }
    }
}
