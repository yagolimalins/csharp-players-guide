Console.Write("Enter X value: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter Y value: ");
int y = int.Parse(Console.ReadLine());

string location = "";

if (x < 0)
{
    if (y > 0) location = "NW";
    else if (y == 0) location = "W";
    else if (y < 0) location = "SW";
}
else if (x == 0)
{
    if (y > 0) location = "N";
    else if (y == 0) location = "here";
    else if (y < 0) location = "S";
}
else if (x > 0)
{
    if (y > 0) location = "NE";
    else if (y == 0) location = "E";
    else if (y < 0) location = "SE";
}

Console.WriteLine($"The enemy is {location}!");