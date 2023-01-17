/*
The Uncoded One has begun an assault on the city of Consolas; the
situation is dire. From a moving airship called the Manticore,
massive fireballs capable of destroying city blocks are being
catapulted into the city.
The city is arranged in blocks, numbered like a chessboard.
The city’s only defense is a movable magical barrier, operated by a
squad of four, that can protect a single city block by putting
themselves in each of the target’s four adjacent blocks, as shown in
the picture to the right.
For example, to protect the city block at (Row 6, Column 5), the
crew deploys themselves to (Row 6, Column 4), (Row 5, Column 5),
(Row 6, Column 6), and (Row7, Column 5).
The good news is that if we can compute the deployment locations fast enough, the crew can be
deployed around the target in time to prevent catastrophic damage to the city for as long as the siege
lasts. The city of Consolas needs a program to tell the squad where to deploy, given the anticipated target.
 */

Console.Title = "Defense of Consolas";

Console.WriteLine("Row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"{row}, {column + 2}");
Console.WriteLine($"{row - 1}, {column - 1}");
Console.WriteLine($"{row}, {column}");
Console.WriteLine($"{row + 1}, {column}");

Console.WriteLine("Good job recruit!");

Console.Beep();