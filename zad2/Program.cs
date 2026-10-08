int startXP = 25;
int startGold = 10;
int trainingAmount = 1;
startXP *= 2;
startGold -= 8;
startGold += 15;
trainingAmount += 1;

Console.WriteLine($"Końcowe xp i złoto: {startXP*trainingAmount}, {startGold*trainingAmount}");