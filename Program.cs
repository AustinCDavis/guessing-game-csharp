//Phase 1

//  Display message asking user to guess secret number
// display a prompt for the user's guess
//take the user's guess as input and save it as a variable
// Display the user's guess back tp the screen

string userGuess;
int userInt;

try
{
    Console.Write("Please guess the secret number: ")

    userGuess = Console.ReadLine();

    userInt = int.Parse(userGuess);

    Console.WriteLine($"You guessed {userInt}!")
}
catch
{
    Console.WriteLine("Hey loser, you need to input an integer!")
}