﻿Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

for (int i = 1; i < 100+1; i++)
{
    if ((i % 3 == 0) && (i % 5 != 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if ((i % 5 == 0) && (i % 3 != 0))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Electric and Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal");
    }
}

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;