namespace _003a_app3a_obdelnik;

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

            int width;
            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out width))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            int height;
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out height))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
