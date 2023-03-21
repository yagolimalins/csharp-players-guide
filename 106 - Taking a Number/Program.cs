int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int AskForNumberInRange(string text, int min, int max)
{
    int result = min - 1;
    while ((result < min) || (result > max)) {
        Console.Write(text);
        result = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"{result} is in range.");
    return result;
}

AskForNumberInRange("Enter a number in 0 to 100 range: ", 0, 100);