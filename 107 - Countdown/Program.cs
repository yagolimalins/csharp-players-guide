int countdown(int number) { 
    if (number == 0)
    {
        return 1;
    }
    else
    {
        Console.WriteLine(number);
        return countdown(number - 1);
    }
}

countdown(10);