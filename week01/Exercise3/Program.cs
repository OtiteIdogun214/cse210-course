using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise2 Project.");

		/*
		 ----------------------------------
		 - Core Requirements -
		 ----------------------------------

		 Work through these core requirements
		 step-by-step to complete the program.
		 Please don't skip ahead and do the
		 whole thing at once, because many
		 people benefit from seeing the program
		 built up step by step.

		 -------------
		 Requirement 1
		 -------------

		 - Instruction 1

		 * Start by asking the user for the magic
		 number.
		 */

		/*
		 - Instruction 2

		 (In future steps, we will
		 change this to

		 * have the computer generate a
		   random number,

		 but to get started, we'll just

		 * let the user decide what it is.)
		 */

		// int magicNumber = 7;

		/*
		 - Instruction 3

		 * Ask the user for a guess.
		 */

		/*
		 Console.Write("What is the magic number? ");
		 string guessInput = Console.ReadLine();
		 int guess = int.Parse(guessInput);
		 */

		/*
		 - Instruction 4

		 * Using an if statement, determine
		   if the user needs to guess higher
		   or lower next time,
		   or tell them if they guessed it.
		 */

		/*
		 if (guess > magicNumber)
		 {
		     Console.WriteLine("Guess lower");
		 }
		 else if (guess < magicNumber)
		 {
		     Console.WriteLine("Guess higher");
		 }
		 else if (guess == magicNumber)
		 {
		     Console.WriteLine("Guess Correct");
		 }
		 else
		 {
		     Console.WriteLine("!!! Please enter in numbers not strings");
		 }
		 */

		/*
		 At this point, you won't have any loops.

		 The following shows the expected output
		 at this point:

		 What is the magic number? 6
		 What is your guess? 4
		 Higher

		 What is the magic number? 6
		 What is your guess? 7
		 Lower

		 What is the magic number? 6
		 What is your guess? 6
		 You guessed it!

		 -------------
		 Requirement 2
		 -------------

		 - Instruction 2

		 * Add a loop that keeps looping as
		   long as the guess does not match
		   the magic number.
		 */

		/*
		 Console.Write("What is the magic number? ");
		 string guessInput = Console.ReadLine();
		 int guess = int.Parse(guessInput);

		 while (guess != magicNumber)
		 {
		     if (guess > magicNumber)
		     {
		         Console.WriteLine("Guess lower");
		     }
		     else if (guess < magicNumber)
		     {
		         Console.WriteLine("Guess higher");
		     }
		     else if (guess == magicNumber)
		     {
		         Console.WriteLine("Guess Correct");
		     }
		     else
		     {
		         Console.WriteLine("!!! Please enter in numbers not strings");
		     }
		 }
		 */

		/*
		 At this point,
		 the user should be able to keep playing
		 until they get the correct answer.

		 The following shows the expected output
		 at this point:

		 What is the magic number? 18
		 What is your guess? 5
		 Higher
		 What is your guess? 6
		 Higher
		 What is your guess? 7
		 Higher
		 What is your guess? 20
		 Lower
		 What is your guess? 19
		 Lower
		 What is your guess? 18
		 You guessed it!

		 -------------
		 Requirement 3
		 -------------
		 Instead of having the user supply the magic number,

		 - Instruction 2

		 generate a random number from 1 to 100.
		 */

		/*
		 Random randomGenerator = new Random();
		 int magicNumber = randomGenerator.Next(1, 11);

		 Console.Write("What is the magic number? ");
		 string guessInput = Console.ReadLine();
		 int guess = int.Parse(guessInput);

		 while (guess != magicNumber)
		 {
		     if (guess > magicNumber)
		     {
		         Console.WriteLine("Guess lower");
		     }
		     else if (guess < magicNumber)
		     {
		         Console.WriteLine("Guess higher");
		     }
		     else if (guess == magicNumber)
		     {
		         Console.WriteLine("Guess Correct");
		     }
		     else
		     {
		         Console.WriteLine("!!! Please enter in numbers not strings");
		     }
		 }
		 */

		/*
		 Play the game and make sure it works!
		 */

		/*
		 ----------------------------------
		 Stretch Challenge
		 ----------------------------------

		 -------------
		 Requirement 1
		 -------------

		 Keep track of how many guesses the
		 user has made and
		 inform them of it at the end of the game.
		 */

		/*
		 Random randomGenerator = new Random();
		 int magicNumber = randomGenerator.Next(1, 11);

		 Console.Write("What is the magic number? ");
		 string guessInput = Console.ReadLine();
		 int guess = int.Parse(guessInput);

		 // Keep track of how many guesses the user has made
		 int guessCount = 0;

		 while (guess != magicNumber)
		 {
		     guessCount++;

		     if (guess > magicNumber)
		     {
		         Console.WriteLine("Guess lower");
		     }
		     else if (guess < magicNumber)
		     {
		         Console.WriteLine("Guess higher");
		     }
		     else if (guess == magicNumber)
		     {
		         Console.WriteLine("Guess Correct");

		         // Inform them of the number of guesses
		         // at the end of the game
		         Console.WriteLine($"It took you {guessCount} guesses.");
		     }
		     else
		     {
		         Console.WriteLine("!!! Please enter in numbers not strings");
		     }
		 }
		 */

		/*
		 -------------
		 Requirement 2
		 -------------

		 After the game is over,
		 ask the user if they want to play again.
		 Then, loop back and play the whole game again
		 and continue this loop as long as they
		 keep saying "yes".
		 */

		string answer = "yes";

		while (answer.ToLower() == "yes")
		{
			Random randomGenerator = new Random();
			int magicNumber = randomGenerator.Next(1, 2); // Generate a random number from 1 to 100

			Console.Write("What is the magic number? ");
			string guessInput = Console.ReadLine();
			int guess = int.Parse(guessInput);

			// Keep track of how many guesses the user has made
			int guessCount = 0;

			guessCount++;

			if (guess > magicNumber)
			{
				Console.WriteLine("Guess lower");
			}
			else if (guess < magicNumber)
			{
				Console.WriteLine("Guess higher");
			}
			else if (guess == magicNumber)
			{
				Console.WriteLine("Guess Correct");

				// Inform them of the number of guesses
				// at the end of the game
				Console.WriteLine($"It took you {guessCount} guesses.");

				// Ask the user if they want to play again
				Console.Write("Do you wish to continue playing the game (yes or no)? ");
				answer = Console.ReadLine();

				if (answer == "yes")
				{
					// Continue the loop
				}
				else
				{
					Console.WriteLine("Thank you for playing. Goodbye");
				}
			}
			else
			{
				Console.WriteLine("!!! Please enter in numbers not strings");
			}
		}
	}
}

