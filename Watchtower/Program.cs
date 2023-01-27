Console.WriteLine("What is the x-coordinates of the enemy? ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the y-coordinates of the enemy? ");
int y = Convert.ToInt32(Console.ReadLine());

if (x<0 && y>0) Console.WriteLine("The enemy is in the northwest quadrant.");
if (x==0 && y>0) Console.WriteLine("The enemy is in the northern quadrant.");
if (x>0 && y>0) Console.WriteLine("The enemy is in the northeast quadrant.");
if (x<0 && y==0) Console.WriteLine("The enemy is in the western quadrant.");
if (x==0 && y==0) Console.WriteLine("The enemy is right on top of you!!!!!");
Console.Beep();
if(x>0 && y==0) Console.WriteLine("The enemy is in the eastern quadrant.");
if(x<0 && y<0) Console.WriteLine("The enemy is in the southwestern quadrant.");
if(x==0 && y<0) Console.WriteLine("The enemy is in this southern quadrant");
if(x>0 && y<0) Console.WriteLine("The enemy is in the southeastern quadrant");