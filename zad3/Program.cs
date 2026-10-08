Console.WriteLine("Podaj liczbę racji żywnościowych: ");
int rations = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj liczbę członków drużyny: ");
int members = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj liczbę dni wyprawy: ");
int days = int.Parse(Console.ReadLine());

int FullRations = rations / members;
int EqualRations = rations % members;
double RationsDailyPerTeam = rations / days;
double AvgRationsPerMember = (rations / members) / days;

Console.WriteLine($"Każdy otrzyma {FullRations} racji żywnościowych.\nPo równym podziale zostanie {EqualRations} racji.\nNa drużynę przypada {RationsDailyPerTeam:F2} racji dziennie.\nKażdy członek drużyny otrzyma średnio {AvgRationsPerMember:F2} racji dziennie.");