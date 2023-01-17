Console.WriteLine("What is your name? "); 

string myName = Console.ReadLine();

Console.WriteLine("Hello there, " + myName + "!");

// Recolors the terminal
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

// Removes everything form the console. 
Console.Clear();

// When adding paths to code, for example say you need the code to access a specific directory, doing something like
// C:\Users\chris won't work so you'd need to use the escape character \ plus the other character you want \
Console.WriteLine("C:\\Users\\chris");

// Or you can do the same things by using an @ symbol in front of the first "
Console.WriteLine(@"C:\Users\chris");


