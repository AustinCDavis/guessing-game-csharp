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

//Phase 5
// Use a random number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

//Phase 6
// Inform the user if their guess was too high or too low, when they guess incorrectly.

//Phase 7
// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
//     Easy - this gives the user eight guesses.
//     Medium - this gives the user six guesses.
//     Hard - this gives the user four guesses.



Random rnd = new Random();
string userGuess;
string highLowMessage;
string difficultyLevel;
int userInt;
int secretNumber = rnd.Next(1, 100);
int guessCount = 0;
int maxGuesses = 0;

Console.WriteLine("Choose your difficulty level:");
Console.WriteLine("Enter 1: Easy");
Console.WriteLine("Enter 2: Medium");
Console.WriteLine("Enter 3: Hard");

difficultyLevel = Console.ReadLine();

switch(difficultyLevel)
{
    case "1":
    maxGuesses = 8;
    break;

    case "2":
    maxGuesses = 6;
    break;

    case "3":
    maxGuesses = 4;
    break;

    default:
    Console.WriteLine("You entered an invalid option. Please select 1, 2, or 3.");
    break;
}

while(guessCount < maxGuesses)
{

    try
    {
        Console.Write($"Can you guess the secret number? You get four guesses. You have {maxGuesses - guessCount} guess(es) remaining. Please enter your guess: ");

        userGuess = Console.ReadLine();

        userInt = int.Parse(userGuess);

        if(userInt == secretNumber)
        {
            Console.WriteLine("You guessed the secret number. Good Job!");
            break;
        }
        else
        {
           highLowMessage = userInt > secretNumber ? "Your guess was too high! Better luck next time loser!" : "Your guess was too low! Better luck next time loser!";
           
           Console.WriteLine(highLowMessage);
        }
    }
    catch
    {
        Console.WriteLine("Hey loser, you need to input an integer!");
    }

    guessCount++;
}