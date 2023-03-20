Console.Title = "Defense of Consolas";

Console.BackgroundColor = ConsoleColor.Black;

Console.Write("Target Row: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Target Column: ");
int column =  int.Parse(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"({row}, {column - 1})");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"({row - 1}, {column})");
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"({row}, {column + 1})");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine($"({row + 1}, {column})");
Console.BackgroundColor = ConsoleColor.Black;

Console.Beep();