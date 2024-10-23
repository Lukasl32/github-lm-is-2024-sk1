namespace _004_app4_generator;

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

            int count;
            int min;
            int max;

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

            int[] output = new int[count];

            Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, max, min);

            Random random = new Random();

            Console.WriteLine("\nNáhodná čísla: ");
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = random.Next(min, max+1);
                Console.Write(" {0} ", output[i]);
            }

            Console.ReadKey();
        }
    }
}
