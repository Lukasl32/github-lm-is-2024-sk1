namespace _002b_app2b_soucet_cifer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeate = "a";
            while (repeate.Equals("a"))
            {
                Console.Clear();
                Console.WriteLine("********************************");
                Console.WriteLine("******** Lukáš Moravec *********");

                int number;
                Console.Write("Zadejte celé číslo: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

                int sum = 0, product = 1;
                string numberString = Convert.ToString(number);

                foreach (var item in numberString)
                {
                    int digit = Convert.ToInt32(item) - 48; // převedení char na int + korekce odečtem 48, které odpovídá ASCII '0'
                    sum += digit;     // součet číslic v čísle
                    product *= digit; // součin číslic v čísle
                }

                Console.WriteLine($"\nSoučet cifer čísla \"{number}\" je: {Math.Abs(sum)}");
                Console.WriteLine($"\nSoučin cifer čísla \"{number}\" je: {Math.Abs(product)}");

                Console.ReadKey();
            }
        }
    }
}
