Console.Write("Input a number: ");
int number = int.Parse(Console.ReadLine());
int remainder = number % 2;

if (remainder == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}