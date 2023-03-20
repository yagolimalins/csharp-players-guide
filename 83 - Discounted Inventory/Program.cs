Console.Write(@"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? ");

int choice = int.Parse(Console.ReadLine());

string item = "";
double price = 0;
bool itemExists = true;

switch (choice)
{
    case 1:
        item = "Rope";
        price = 10;
        break;
    case 2:
        item = "Torches";
        price = 15;
        break;
    case 3:
        item = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        item = "Clean Water";
        price = 1;
        break;
    case 5:
        item = "Machete";
        price = 20;
        break;
    case 6:
        item = "Canoe";
        price = 200;
        break;
    case 7:
        item = "Food Supplies";
        price = 1;
        break;
    default:
        itemExists = false;
        break;
};


if (itemExists)
{
    Console.Write("What is your name? ");
    string name = Console.ReadLine();
    if (name.ToLower() == "yago")
    {
        price /= 2;
    };
    Console.WriteLine($"{item} cost {price} gold.");
}
else
{
    Console.WriteLine("Apologies. I do not know that one.");
};