internal class Program
{
    private static void Main(string[] args)
    {
        string? again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("******* Výpis řady čísel *******");
            Console.WriteLine("********************************");
            Console.WriteLine("******** Lukáš Moravec *********");

            // vstup hodnot do programu
            //int num1 = int.Parse(Console.ReadLine()); // špatné řešení
            int first;
            Console.Write("Zadejte 1. celé číslo řady: ");
            while (!int.TryParse(Console.ReadLine(), out first))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");
            Console.WriteLine("Zvolené první číslo řady: {0}", first);

            int last;
            Console.Write("Zadejte poslední celé číslo řady: ");
            while (!int.TryParse(Console.ReadLine(), out last))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");
            Console.WriteLine("Zvolené první číslo řady: {0}", last);

            int step;
            Console.Write("Zadejte krok, po kterém bude řada narůstat: ");
            while (!int.TryParse(Console.ReadLine(), out step))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");
            Console.WriteLine("Zvolený krok: {0}", step);

            for (int i = first; i < last; i+=step)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine($"Pro opakování programu stiskni klávesu \"{again}\"");
            Console.Write("Volba: ");
            again = Console.ReadLine();
        }
    }
}