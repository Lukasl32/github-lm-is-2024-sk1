namespace _013_app13_prevod_z_binarni_soustavy;

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

            uint number, numberBackup;
            uint[] binNumber = new uint[32];

            Console.Write("Zadejte přirozené číslo v desítkové soustavě [>0]: ");
            while (!uint.TryParse(Console.ReadLine(), out number))
                Console.Write("Chybně zadané celé číslo!! \nZadejte znovu: ");

            Console.WriteLine("\nVýpočet... ");
            uint i;
            for (i = 0; i < binNumber.Length; i++)
            {
                binNumber[binNumber.Length - 1 - i] = number % 2;
                Console.WriteLine("Celá část: {0} | Zbytek po dělení: {1}", number, binNumber[binNumber.Length - 1 - i]);
                number = (number - binNumber[i]) / 2;
                if (number == 0)
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Výsledek: ");
            Console.Write("BIN: ");
            for (int j = 0; j < i; j++)
            {
                Console.Write(binNumber[i - j]);
            }


            Console.ReadKey();
        }
    }
}
