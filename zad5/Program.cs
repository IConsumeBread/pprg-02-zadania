Console.Write("Podaj imię bohatera: ");
string name = Console.ReadLine();

Console.Write("Podaj maksymalne punkty życia: ");
int maxhp = int.Parse(Console.ReadLine());

Console.Write("Podaj aktualne punkty życia przed walką: ");
int currenthp = int.Parse(Console.ReadLine());

Console.Write("Podaj podstawowe obrażenia broni: ");
int weaponDamage = int.Parse(Console.ReadLine());

Console.Write("Podaj premię do siły: ");
int strengthModifier = int.Parse(Console.ReadLine());

Console.Write("Podaj mnożnik ataku specjalnego (np. 1.5): ");
double specialMultiplier = double.Parse(Console.ReadLine());

Console.Write("Podaj liczbę wykonanych zwykłych ataków: ");
int basicAttackAmount = int.Parse(Console.ReadLine());

int basicAttackDamage = weaponDamage + strengthModifier;
int specialAttackDamage = (int)(basicAttackAmount * specialMultiplier);
int totalDamage = (basicAttackAmount * basicAttackDamage) + specialAttackDamage;

double hpPercentage = ((double)currenthp / maxhp) * 100;

bool isAlive = currenthp > 0;
bool isAtFullHealth = currenthp == maxhp;

Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {name}");
Console.WriteLine($"Zdrowie {hpPercentage}");
Console.WriteLine($"Zwykły atak: {basicAttackDamage}");
Console.WriteLine($"Atak specjalny: {specialAttackDamage}");
Console.WriteLine($"Łączne zadane obrażenia: {totalDamage}");
Console.WriteLine($"Żyje: {isAlive}");
Console.WriteLine($"Pełne zdrowie: {isAtFullHealth}");
Console.WriteLine("=====================================");