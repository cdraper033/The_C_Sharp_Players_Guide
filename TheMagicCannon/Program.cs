for (int turn = 1; turn <= 100; turn++)
{
    if (turn % 5 == 0 && turn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\nElectric + fire blast");
    }
    else if (turn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nElectric blast");
    }
    else if (turn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nFire blast");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Normal blast");
    }
}