// See https://aka.ms/new-console-template for more information

CountdownEvent(10);

void CountdownEvent(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    CountdownEvent(number - 1);
}