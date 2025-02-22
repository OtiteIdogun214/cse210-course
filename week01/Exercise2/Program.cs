using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise2 Project.");

		/*
		  Write a program that determines the letter grade
		  for a course according to the following scale:

		  A >= 90
		  B >= 80
		  C >= 70
		  D >= 60
		  F < 60
		*/

		/* --------------------
		  - Core Requirements -
		  ---------------------
		*/

		/* Requirement 1
		*/

		// Instruction 1
		// Ask the user for their grade percentage,

		// Algorithm 1: Display output of prompt question to the console
		Console.Write("Please enter your in percentage (%): ");

		// Algorithm 2: Get input of grade on the console
		string gradeInput = Console.ReadLine();

		// Algorithm 3: Convert grade input from default string type
		//              to integer type
		int grade = int.Parse(gradeInput);
		Console.WriteLine(grade);


		// Instruction 2
		// then write a series of if, else if, else statements
		// to print out the appropriate letter grade.
		// (At this point, you'll have a separate print statement
		// for each grade letter in the appropriate block.)

		// Algorithm 1: Write a series of if, else if, else statements
		if (grade >= 90)
		{
			// Algorithm 2: Print out the appropriate letter grade.
			Console.WriteLine("Grade: A");
		}
		else if (grade >= 80)
		{
			Console.WriteLine("Grade: B");
		}
		else if (grade >= 70)
		{
			Console.WriteLine("Grade: C");
		}
		else if (grade >= 60)
		{
			Console.WriteLine("Grade: D");
		}
		else if (grade < 60)
		{
			Console.WriteLine("Grade: F");
		}


		/* Requirement 2
		*/

		// Assume that you must have at least a 70 to pass the class.
		// After determining the letter grade and printing it out.

		// * Instruction 1
		// Add a separate if statement to determine if the user passed the course,

		// * Instruction 2
		// and if so display a message to congratulate them.
		// If not, display a different message to encourage them for next time.

		// Algorithm 1: // Determine if the user passed the course,
		if (grade >= 60)
		{
			// Algorithm 2: Print out a display message to congratulate them.
			Console.WriteLine("You passed the class");
		}
		// Algorithm 3: Determine if the user does not (If not) pass the course
		else if (! (grade >= 60))
		{
			// Algorithm 4: Display a different message to encourage them for next time.
			Console.WriteLine("You did not pass the course. Try again next time");
		}

		/* Requirement 3
		*/
		// Change your code from the first part,
		// so that instead of printing the letter grade
		// in the body of each if, else if, or else block,
		// instead create a new variable called letter and then

		// in each block, set this variable to the appropriate value.

		// Finally, after the whole series of if, else if, else statements,
		// have a single print statement that prints the letter grade once.

		Console.WriteLine("\nRequirement 3");

		char letter;

		if (grade >= 90)
		{
			letter = 'A';
		}
		else if (grade >= 80)
		{
			letter = 'B';
		}
		else if (grade >= 70)
		{
			letter = 'C';
		}
		else if (grade >= 60)
		{
			letter = 'D';
		}
		else
		{
			letter = 'F';
		}

		// Print out the appropriate letter grade.
		Console.WriteLine($"Grade: {letter}");





		/*
		  ---------------------
		  - Stretch Challenge -
		  ---------------------
		*/

		/* Requirement 1
		*/

		/*
		Add to your code the ability to include
		a "+" or "-" next to the letter grade,
		such as B+ or A-. For each grade,
		you'll know it is a "+" if the last digit
		is >= 7. You'll know it is a minus
		if the last digit is < 3 and
		otherwise it has no sign.
		*/

		/*
		After your logic to determine the grade letter,
		add another section to determine the sign.

		* Instruction
		Save this sign into a variable. Then,
		display both the grade letter and
		the sign in one print statement.

		Hint: To get the last digit, you could
		divide the number by 10, and get the remainder.
		You might review the standard math operators and
		find the one that does division and
		gives you the remainder.

		At this point, don't worry about the exceptional cases of A+, F+, or F-.
		*/


		/* Requirement 2
		*/

		/*
		Recognize that there is no A+ grade, only A and A-.

		* Instruction
		Add some additional logic to your program to
		detect this case and handle it correctly.
		*/

		/* Requirement 3
		*/

		/*
		Similarly, recognize that there is no F+
		or F- grades, only F.

		* Instruction
		Add additional logic to your program
		to detect these cases and handle them correctly.
		*/
	}
}
