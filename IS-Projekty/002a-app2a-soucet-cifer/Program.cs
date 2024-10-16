namespace _002a_app2a_soucet_cifer;

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

            int sum = 0, product = 1, numberOriginal = number;

            do
            {
                sum += number % 10;     // součet číslic v čísle
                product *= number % 10; // součin číslic v čísle
                number /= 10; // zmenšení čísla o již zpracovanou číslici
            }
            while (number != 0);

            Console.WriteLine($"\nSoučet cifer čísla \"{numberOriginal}\" je: {Math.Abs(sum)}");
            Console.WriteLine($"\nSoučin cifer čísla \"{numberOriginal}\" je: {Math.Abs(product)}");

            Console.ReadKey();
        }
    }
}
