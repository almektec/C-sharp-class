// establish game's starting state

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

// ask player to choose the manticore's distance

int range = AskForNumberInRange("how far away from the city do you want to put the manticore?", 0, 100);
Console.Clear();

while (cityHealth > 0 && manticoreHealth > 0)
{
    // round stats
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);

    // dmg expectancy
    int damage = DamageForRound(round);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"cannon will deal {damage} damage this round.");

    // ask player to choose the cannon range
    Console.ForegroundColor = ConsoleColor.White;
    int targetRange = AskForNumber("enter cannon range:");

    Console.ForegroundColor = ConsoleColor.Cyan;
    DisplayOverOrUnder(targetRange, range);

    // manticore hit dmg
    if (targetRange == range) manticoreHealth -= damage;

    // city hit dmg
    if (manticoreHealth > 0) cityHealth--;

    // next round
    round++;
}

// win or lose screen

bool won = cityHealth > 0;
DisplayWinOrLose(won);

void DisplayWinOrLose(bool won)
{
    if (won)
    {        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("manticore has been destroyed");    }
    else
    {        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("city has been destroyed");    }
}


// cannon hit stats

void DisplayOverOrUnder(int targetRange, int range)
{
    if (targetRange < range) Console.WriteLine("no hit");
    else if (targetRange > range) Console.WriteLine("no hit");
    else Console.WriteLine("good hit");
}

// round stats

void DisplayStatus(int round, int cityHealth, int manticoreHealth) =>
    Console.WriteLine($"stats: round: {round}  city: {cityHealth}/15  manticore: {manticoreHealth}/10");

// dmg stuff

int DamageForRound(int roundNumber)
{
    if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10; 
    else if (roundNumber % 5 == 0) return 3; 
    else if (roundNumber % 3 == 0) return 3;
    return 1; 
}


// ask player 4 number

int AskForNumber(string text)
{
    Console.Write(text + " ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


// makes sure number is in range

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {        int number = AskForNumber(text);
        if (number >= min && number < max)
            return number;    }
}