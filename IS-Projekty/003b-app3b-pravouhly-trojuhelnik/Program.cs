namespace _003b_app3b_pravouhly_trojuhelnik;

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

            int height;
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            while (!int.TryParse(Console.ReadLine(), out height))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
