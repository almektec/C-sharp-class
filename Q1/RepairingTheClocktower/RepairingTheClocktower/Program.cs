// take a number as input from the console

Console.Write("pick a number: ");
int number = Convert.ToInt32(Console.ReadLine());

// display the word tick if the number is even, dispaly the word tock if the number is odd

if (number % 2 == 0) Console.WriteLine("Tick");
else Console.WriteLine("Tock");