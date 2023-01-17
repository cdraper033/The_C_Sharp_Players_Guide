Console.WriteLine("Welcome to the Triangle farmer!!!");

Console.WriteLine("What is the width of the triangle? ");
string widthText = Console.ReadLine();
float width = Convert.ToSingle(widthText);

Console.WriteLine("What is the height of the triangle? ");
string heightText = Console.ReadLine();
float height = Convert.ToSingle(heightText);

float area = (width * height) / 2;
Console.WriteLine("The area is " + area);