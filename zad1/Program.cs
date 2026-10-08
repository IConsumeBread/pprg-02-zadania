string name = "Mira";
char symbol = '@';
int level = 2;
int gold = 35;
double weight = 7.5;
bool hasMap = true;

gold = 67;
hasMap = !hasMap;

Console.WriteLine($"=== Ekwipunek ===\nImię: {name} (string)\nSymbol: {symbol} (char)\nPoziom: {level} (int)\nZłoto: {gold}g (int)\nWaga: {weight}kg (double)");
if (hasMap)
{
    Console.WriteLine("Mapa: tak (bool)");
}
else
{
    Console.WriteLine("Mapa: nie (bool)");
}
