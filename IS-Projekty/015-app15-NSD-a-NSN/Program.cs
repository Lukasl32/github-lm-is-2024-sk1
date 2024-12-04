Console.Clear();
Console.WriteLine("********************************");
Console.WriteLine("******** Lukáš Moravec *********");

bool repeat = false;

do
{
    var num1 = GetValue<ulong>("Zadejte první číslo: ");
    var num2 = GetValue<ulong>("Zadejte první číslo: ");

    ulong nsd = GetNSD(num1, num2);
    ulong nsn = GetNSN(num1, num2);

    Console.WriteLine();
    Console.WriteLine("NSD čísel {0} a {1} je: {2}", num1, num2, nsd);
    Console.WriteLine("NSN čísel {0} a {1} je: {2}", num1, num2, nsn);

    Console.ReadKey();
}
while (repeat);


static ulong GetNSD(ulong a, ulong b)
{
    while (a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }
    return a;
}

static ulong GetNSN(ulong a, ulong b)
{
    return (a*b)/GetNSD(a, b);
}

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