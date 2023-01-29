int u1Num;
do
{
    Console.WriteLine("User 1, please enter a number between 0 and 100: ");
    string u1Response = Console.ReadLine();
    u1Num = Convert.ToInt32(u1Response);
}

while (u1Num < 0 || u1Num > 100);


while (true)
{ 
    Console.WriteLine("\nUser 2, please enter a number between 0 and 100: ");
    int u2Num = Convert.ToInt32(Console.ReadLine());
    if (u2Num > u1Num){
        Console.Write("Number is too high, guess again.");
        continue;
    }

    if (u2Num < u1Num)
    {
        Console.Write("Number is too low, guess again.");
        continue;
    }
    Console.WriteLine("Yayyy you guessed the number!");
    break;
}