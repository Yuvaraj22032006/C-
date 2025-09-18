string? readResult; //initialize for ReadLine
string valueEntered = ""; // Assign the readResult to valuEntered
int numValue = 0; //Then get the from valueEntered either string or integer and convert it to integer and assign it to numValue
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();  //Assign a value
    if (readResult != null) //checks whether or not the value is entered or not
    {
        valueEntered = readResult;//Assig entered value to valueEntered
    }

    validNumber = int.TryParse(valueEntered, out numValue); //in valid number convert the value entered to integer

    if (validNumber == true) //if validNumber is false it will not execute this block until validNumber is true and exit the loop
    {
        if (numValue <= 5 || numValue >= 10) // Checks the value is less than 5 or more than 5 if it meets this condition it will execute this block or exits the loop
        {
            validNumber = false; // Assigns false to validNumber so that it can return to the start of the code
            Console.Write($"You entered {numValue}. Please enter a number between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }

} while (validNumber == false);

Console.WriteLine($"Your input valu ({numValue}) has been accepted.");

readResult = Console.ReadLine();