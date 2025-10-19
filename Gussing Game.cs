string guessWord = "ZEX";
string? guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGussess = false;


do
{
    if (guessCount < guessLimit)
    {
        Console.Write("Enter your guess:");
        if (guess != null) {
            guess = Console.ReadLine().ToUpper();
        }
        guessCount++;
        
    }
    else
    {
        outOfGussess = true;
    }

    if (guess == guessWord)
    {
        Console.WriteLine("You win!");
    }
    else if(outOfGussess)
    {
        Console.WriteLine("You lose!");
    }
}while (guess != guessWord && !outOfGussess) ;
