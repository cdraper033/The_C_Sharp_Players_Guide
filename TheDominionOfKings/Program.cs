Console.WriteLine("How many provinces do you have? ");
int numOfProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have? ");
int numOfDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many provinces do you have? ");
int numOfEstates = Convert.ToInt32(Console.ReadLine());

int total = numOfProvinces * 6 + numOfDuchies * 3 + numOfEstates * 1;
Console.WriteLine("Your total is: " + total);