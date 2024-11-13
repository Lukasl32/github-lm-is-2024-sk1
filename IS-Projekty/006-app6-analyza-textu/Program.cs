namespace _006_app6_analyza_textu;

internal class Program
{
    static void Main(string[] args)
    {
        char[] vowels = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'č', 'ď', 'ř', 'š', 'ť', 'ž' };
        char[] constatns = ['a', 'e', 'i', 'o', 'u', 'y', 'á', 'é', 'í', 'ó', 'ú', 'ů', 'ý']; // zkrácená deklarace pole
        char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];

        string repeate = "a";
        while (repeate.Equals("a"))
        {
            int vowlCount = 0, constatCount = 0, numberCount = 0, otherCharCount = 0;

            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("******** Lukáš Moravec *********");

            Console.Write("Zadejte větu k analýze: ");
            string? text = Console.ReadLine();

            if (text != null)
            {
                text = text.ToLower();
                foreach (var item in text)
                {
                    if (vowels.Contains(item))
                        vowlCount++;
                    else if (constatns.Contains(item))
                        constatCount++;
                    else if (numbers.Contains(item))
                        numberCount++;
                    else
                        otherCharCount++;
                }
            }

            Console.WriteLine("Výsledek analýzy:");
            Console.WriteLine($"Počet souhlásek: {vowlCount}");
            Console.WriteLine($"Počet samohlásek: {constatCount}");
            Console.WriteLine($"Počet čísel: {numberCount}");
            Console.WriteLine($"Počet ostatních znaků: {otherCharCount}");

            Console.ReadKey();
        }
    }
}
