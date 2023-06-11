//Phase 1
// Display message asking user to guess secret number
// Display a prompt for the user's guess
// Take the user's guess as input and save it as a variable
// Display the user's guess back tp the screen


//Phase 2
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

string userGuess;
int userInt;
int secretNumber = 42;
string message;

try
{
    Console.Write("Please guess the secret number: ");

    userGuess = Console.ReadLine();

    userInt = int.Parse(userGuess);

    message = userInt == secretNumber ? "You guessed the secret number. Good Job!" : "You failed to guess the secret number. Better luck next time loser!";

    Console.WriteLine(message);
}
catch
{
    Console.WriteLine("Hey loser, you need to input an integer!");
}