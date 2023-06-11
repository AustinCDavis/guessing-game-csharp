//Phase 1
// Display message asking user to guess secret number
// Display a prompt for the user's guess
// Take the user's guess as input and save it as a variable
// Display the user's guess back tp the screen


//Phase 2
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

//Phase 3
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2

//Phase 4
// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

string userGuess;
int userInt;
int secretNumber = 42;
string message;
int guessCount = 1;

while(guessCount <= 4)
{

    try
    {
        Console.Write($"Can you guess the secret number? You get four guesses. You're on Guess {guessCount}. Please enter your guess:");

        userGuess = Console.ReadLine();

        userInt = int.Parse(userGuess);

        // message = userInt == secretNumber ? "You guessed the secret number. Good Job!" : $"You failed to guess the secret number. Better luck next time loser!";

        // Console.WriteLine(message);

        if(userInt == secretNumber)
        {
            Console.WriteLine("You guessed the secret number. Good Job!");
            break;
        }
        else
        {
            Console.WriteLine("You failed to guess the secret number. Better luck next time loser!");
        }
    }
    catch
    {
        Console.WriteLine("Hey loser, you need to input an integer!");
    }

    guessCount++;
}