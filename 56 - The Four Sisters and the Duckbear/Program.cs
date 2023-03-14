Console.Write("Number of chocolate eggs: ");
int chocolateEggsGathered = int.Parse(Console.ReadLine());
Console.WriteLine($"Each sister gets {chocolateEggsGathered / 4} chocolate eggs");
Console.WriteLine($"Duckbear gets {chocolateEggsGathered % 4} chocolate eggs");