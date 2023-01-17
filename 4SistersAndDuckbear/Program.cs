Console.WriteLine("How many chocolate eggs were laid? ");
string numberOfEggsText = Console.ReadLine();
int numberOfEggs = Convert.ToInt32(numberOfEggsText);

// There are 4 sisters who must split the chocolate eggs
// this will determine how many they get and duckbear gets
// the remainder
float sistersResult = numberOfEggs / 4;
float duckbearResult = numberOfEggs % 4;

Console.WriteLine("Each sister gets " + sistersResult + " eggs.");
Console.WriteLine("Duckbear gets " + duckbearResult + " eggs.");