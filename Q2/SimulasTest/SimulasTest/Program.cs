//define an enumeration for the state of the chest
//make a variable whose type is this new enumeration
ChestState currentState = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");

    string input = Console.ReadLine();
    //write code to allow you to manipulate the chest with the lock, unlock, open, and close cmds
    if (currentState == ChestState.Locked && input == "unlock") currentState = ChestState.Closed;
    if (currentState == ChestState.Closed && input == "open") currentState = ChestState.Open;
    if (currentState == ChestState.Open && input == "close") currentState = ChestState.Closed;
    if (currentState == ChestState.Closed && input == "lock") currentState = ChestState.Locked;
}

enum ChestState { Open, Closed, Locked }

//loop forever