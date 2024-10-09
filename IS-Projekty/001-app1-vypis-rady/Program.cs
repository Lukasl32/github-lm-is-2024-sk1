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

            Console.WriteLine($"Pro opakování programu stiskni klávesu \"{again}\"");
            Console.Write("Volba: ");
            again = Console.ReadLine();
        }
    }
}