namespace _010_app10_konvergetni_rady;

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

            double accuracy;
            int[] output, arrayBackup;
            Random random = new();

            Console.Write("Zadejte přesnost (reálné číslo - menší hodnota, tím přesnější výpočet): ");
            while (!double.TryParse(Console.ReadLine(), out accuracy))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            double i = 1;
            double sign = 1;
            double piQuarter = 1;

            while ((1 / i) >= accuracy)
            {
                i += 2;
                sign = -sign;
                piQuarter += sign * 1 / i;

                if (sign == 1)
                    Console.WriteLine("Zlomek +1/{0}; aktuální hodnota PI = {1}", i, 4 * piQuarter);
                else
                    Console.WriteLine("Zlomek -1/{0}; aktuální hodnota PI = {1}", i, 4 * piQuarter);
            }

            Console.WriteLine("\n\nHodnota čísla PI = {0}", 4 * piQuarter);
            //Console.WriteLine("\n\nHodnota čísla PI = {0:f4}", 4 * piQuarter); // se zaokrouhlením na 4 desetinná místa

            Console.WriteLine("\n\nReference čísla PI = {0}", Math.PI);

            Console.ReadKey();
        }
    }
}
