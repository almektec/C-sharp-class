// See https://aka.ms/new-console-template for more information

// Change the window Title to "Defense of Consolas"
Console.Title = "Defense of Consolas";

var current_bg = Console.BackgroundColor;
var current_fg = Console.ForegroundColor;

// to Display the instruction in a differnet color of your choosing
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
// Ask the user for the target row
Console.Write("Target Row? ");
Console.BackgroundColor = current_bg;
Console.ForegroundColor = current_fg;
var row = Console.ReadLine();
// Ask the user for the target column
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Target Column? ");
Console.BackgroundColor = current_bg;
Console.ForegroundColor = current_fg;
var column = Console.ReadLine();

Console.WriteLine( "("+ row + "," + column + ")" );

int protected_row = 0;
if (row !=null)
{
    protected_row = int.Parse(row);
}
int protected_column = 0;
if(column != null)
{
    protected_column = int.Parse(column);
}

if(protected_row >= 1 && protected_row <= 8)
{
    if(protected_column >= 1 && protected_column <= 8)
    {

        Console.WriteLine("Deploy to: ");
        Console.WriteLine("(" + (protected_row) + ", " + (protected_column - 1) + ")");
        Console.WriteLine("(" + (protected_row - 1) + ", " + (protected_column) + ")");
           Console.WriteLine("(" + (protected_row) + ", " + (protected_column + 1) + ")");
        Console.WriteLine("(" + (protected_row + 1) + ", " + (protected_column) + ")");
        Console.Beep();
    }
}

// Compute the neighboring rows and columns of where to deploy your squad



// Play a sound with Console.Beep when the results have been computed and displayed
