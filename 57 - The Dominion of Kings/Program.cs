Console.Write("Number of provinces: ");
int provincesPoints = int.Parse(Console.ReadLine()) * 6;
Console.Write("Number of duchies: ");
int duchiesPoints = int.Parse(Console.ReadLine()) * 3;
Console.Write("Number of estates: ");
int estatesPoints = int.Parse(Console.ReadLine()) * 1;

int finalScore = provincesPoints + duchiesPoints + estatesPoints;

Console.WriteLine($"Your total points are: {finalScore}");