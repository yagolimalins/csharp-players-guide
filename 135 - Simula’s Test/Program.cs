Chest chest = Chest.open;

string command;

while (true)
{
    if (chest == Chest.open)
    {
        Console.Write("The chest is open. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "close") chest = Chest.closed;
    }
    else if (chest == Chest.closed)
    {
        Console.Write("The chest is closed. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "lock") { chest = Chest.locked; }
        else if (command == "open") { chest = Chest.open; }
    }
    else if (chest == Chest.locked)
    {
        Console.Write("The chest is locked. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "unlock") chest = Chest.closed;
    }
}

enum Chest { open, closed, locked };