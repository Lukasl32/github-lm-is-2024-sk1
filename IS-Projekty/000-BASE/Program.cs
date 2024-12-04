Console.Clear();
Console.WriteLine("********************************");
Console.WriteLine("******** Lukáš Moravec *********");

bool repeat = false;

do
{
    var array = GenerateRandomArray();

    Console.ReadKey();
}
while (repeat);


static T? GetValue<T>(string text)
{
    T? value;
    Console.Write(text);
    while (true)
    {
        try
        {
            value = (T?)Convert.ChangeType(Console.ReadLine(), typeof(T));
            return value;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chybně zadaná hodnota!!");
            Console.ResetColor();

            Console.Write("\nZadejte znovu: ");
        }
    }
}

static void PrintArray<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[{0}; ", array[i]);
        else if (i == array.Length - 1) Console.WriteLine("{0}]", array[i]);
        else Console.Write("{0}; ", array[i]);
    }
}

static int[] GenerateRandomArray()
{
    (int genCount, int genMin, int genMax) = GetRandomGeneratorConfig();
    return RandomGenerator(genCount, genMin, genMax);
}

static (int count, int min, int max) GetRandomGeneratorConfig()
{
    bool valid = true;
    int count, min, max;

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

    return (count, min, max);
}

static int[] RandomGenerator(int count, int min, int max)
{
    int[] output = new int[count];

    Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, max, min);
    Random random = new();

    for (int i = 0; i < output.Length; i++)
        output[i] = random.Next(min, max + 1);

    return output;
}