Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Black;

int manticoreDistance = int.MaxValue;
int manticoreHealth = 10;
int cityHealth = 15;
int cannonRange;
int turn = 1;
bool gameover = false;

while ((manticoreDistance < 0) || (manticoreDistance > 100))
{
    Console.Clear();
    Console.Beep();
    Console.Beep();
    Console.Write("Player 1, how far away from the city do you want to station the Manticore (0-100)? ");
    manticoreDistance = int.Parse(Console.ReadLine());
}

Console.Clear();
Console.Beep();
Console.WriteLine("Player 2, it is your turn.");

while (!gameover)
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {turn} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage(turn)} damage this round.");
    Console.Write("Enter desired cannon range: ");
    cannonRange = int.Parse(Console.ReadLine());

    if (cannonRange == manticoreDistance)
    {
        manticoreHealth -= cannonDamage(turn);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("That round was a DIRECT HIT!");
    }
    else if (cannonRange > manticoreDistance)
    {
        cityHealth -= 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (cannonRange < manticoreDistance)
    {
        cityHealth -= 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target.");
    }

    turn++;

    if (manticoreHealth <= 0)
    {
        gameover = true;
        gameoverAlert();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else if (cityHealth <= 0)
    {
        gameover = true;
        gameoverAlert();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city of Consolas has been destroyed! Behold The Uncoded One!");
    }
}

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

int cannonDamage(int turn)
{
    if ((turn % 3 == 0) && (turn % 5 != 0))
    {
        return 3;
    }
    else if ((turn % 5 == 0) && (turn % 3 != 0))
    {
        return 3;
    }
    else if ((turn % 3 == 0) && (turn % 5 == 0))
    {
        return 10;
    }
    else
    {
        return 1;
    }
}

void gameoverAlert()
{
    Console.Beep();
    Console.Beep();
    Console.Beep();
}