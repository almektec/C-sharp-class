// Ask the user for an x value and a y value.

Console.Write("x value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y value: ");
int y = Convert.ToInt32(Console.ReadLine());

// make if statements, relational operators, and display message about what direction the enemy is coming from


if (x < 0 && y > 0) Console.WriteLine("The enemy is NW");
if (x == 0 && y > 0) Console.WriteLine("The enemy is N");
if (x > 0 && y > 0) Console.WriteLine("The enemy is NE");
if (x < 0 && y == 0) Console.WriteLine("The enemy is W:");
if (x == 0 && y == 0) Console.WriteLine("The enemy is here");
if (x > 0 && y == 0) Console.WriteLine("The enemy is E");
if (x < 0 && y < 0) Console.WriteLine("The enemy is SW");
if (x == 0 && y < 0) Console.WriteLine("The enemy is S");
if (x > 0 && y < 0) Console.WriteLine("The enemy is SE");

