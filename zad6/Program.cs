Console.WriteLine("Podaj imię postaci: ");
string name = Console.ReadLine();

const int maxhp = 100;
Console.WriteLine("Podaj hp postaci: ");
int currenthp = int.Parse(Console.ReadLine());
bool isAlive = currenthp > 0;
bool ismaxhp = currenthp == maxhp;
bool needHealing = currenthp < 100;
double hpPercentage = ((double)currenthp / 100.0) * maxhp;

Console.WriteLine("Podaj symbol drużyny: ");
char symbol = char.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość członków drużyny: ");
int partyMemebers = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj ilość złota: ");
int gold = int.Parse(Console.ReadLine());
int goldPerMember = gold / partyMemebers;
int leftoverGold = gold % partyMemebers;

Console.WriteLine("Podaj licbę zajętych slotów ekwipunku (nie więcej niż 10): ");
const int inventorySlots = 10;
int occupiedSlots = Math.Min(int.Parse(Console.ReadLine()), 10);
int freeSlots = inventorySlots - occupiedSlots;
bool hasFreeSlots = occupiedSlots < 10;


Console.WriteLine("Podaj atak broni: ");
int weaponAttack = int.Parse(Console.ReadLine());
const double weaponAttackMultiplier = 1.5;
int totalAttackDamage = weaponAttack * (int)weaponAttackMultiplier;

Console.WriteLine("Ma mapę?: ");
bool hasMap = bool.Parse(Console.ReadLine());

Console.WriteLine("Ma klucz?: ");
bool hasKey = bool.Parse(Console.ReadLine());

bool ready = isAlive && hasMap || hasKey;

Console.WriteLine("+-----------------------------------------------------+");
Console.WriteLine("|            Karta Bohatera                           |");
Console.WriteLine("+-----------------------------------------------------+");
Console.WriteLine($"Imię postaci: {name}");
Console.WriteLine($"HP: {currenthp}/{maxhp} ({hpPercentage:F2}%)");
Console.WriteLine($"Siła broni: {weaponAttack}");
Console.WriteLine($"Mnożnik siły broni: {weaponAttackMultiplier}");
Console.WriteLine($"Obrażenia ataku: {totalAttackDamage}");
Console.WriteLine("+-----------------------------------------------------+");
Console.WriteLine($"Symbol drużyny: {symbol}");
Console.WriteLine($"Ilość członków drużyny: {partyMemebers}");
Console.WriteLine($"Złoto: {gold}");
Console.WriteLine($"Złoto dla każdej osoby: {goldPerMember}");
Console.WriteLine($"Pozostałe złoto: {leftoverGold})");
Console.WriteLine("+-----------------------------------------------------+");
Console.WriteLine($"Postać żyje: {isAlive}");
Console.WriteLine($"Ma pełne zdrowie: {ismaxhp}");
Console.WriteLine($"Potrzebuje leczenia: {needHealing}");
Console.WriteLine($"Ma wolne miejsce w ekwipunku: {hasFreeSlots}");
Console.WriteLine($"Gotowy do walki: {ready}");