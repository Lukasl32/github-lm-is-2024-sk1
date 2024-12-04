using System.Runtime.CompilerServices;

Console.WriteLine("Kombinovaná úloha - Lukáš Moravec\n");

int count, min, max;
bool valid = true;
int[] output;

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

output = new int[count];
Random random = new();
Console.WriteLine("Konfigurace generátoru je počet čísel: {0}, horní mez: {1}, dolní mez {2}", count, max, min);

Console.WriteLine("Náhodně vygenerovaná čísla: ");
for (int i = 0; i < count; i++)
{
    output[i] = random.Next(min, max);
    Console.Write("{0}, ", output[i]);
}
Console.WriteLine("\n----------------");

void printArray()
{

}