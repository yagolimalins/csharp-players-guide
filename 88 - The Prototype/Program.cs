Console.Write("User 1, enter a number between 0 and 100: ");
int number = int.Parse(Console.ReadLine());
Console.Clear();

bool gameover = false;

Console.WriteLine("User 2, guess the number.");

while (!gameover)
{
    Console.Write("What is your next guess? ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == number)
    {
        Console.Clear();
        Console.WriteLine("You guessed the number!");
        gameover = true;
    }
    else if (guess < number)
    {
        Console.Clear();
        Console.WriteLine($"{guess} is too low.");
    }
    else if (guess > number)
    {
        Console.Clear();
        Console.WriteLine($"{guess} is too high.");
    }
}