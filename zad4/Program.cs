Console.WriteLine("Wpisz liczbę hp:");
int hp = int.Parse(Console.ReadLine());

bool isAlive = hp > 0;
if (!isAlive)
    {
    Console.WriteLine("No nie możesz kontynuować, bo trochę nie żyjesz.");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Wpisz liczbę mikstur:");
    int potions = int.Parse(Console.ReadLine());

    Console.WriteLine("Czy masz mapę? (true/false)");
    bool hasMap = bool.Parse(Console.ReadLine());

    Console.WriteLine("Czy masz klucz? (true/false)");
    bool hasKey = bool.Parse(Console.ReadLine());

    bool fullHealth = hp == 100;
    bool needsHealing = hp < 50;
    bool hasPotions = potions > 0;
    bool hasMapOrKey = hasMap || hasKey;
    bool isReady = isAlive && hasPotions && hasMapOrKey;

    Console.WriteLine($"Żyje: {isAlive}");
    Console.WriteLine($"Ma pełne zdrowie: {fullHealth}");
    Console.WriteLine($"Potrzebuje leczenia: {needsHealing}");
    Console.WriteLine($"Ma mikstury: {hasPotions}");
    Console.WriteLine($"Ma mapę lub klucz: {hasMapOrKey}");
    Console.WriteLine($"Gotowy: {isReady}");
}