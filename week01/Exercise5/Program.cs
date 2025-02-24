using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise5 Project.");
		
		DisplayWelcome();
		
		/*
		string userName = PromptUserName();
		int userNumber = PromptUserNumber();
		double squaredNumber = SquareNumber(userNumber);
		*/
		
		DisplayResult();
		//DisplayResult2(userName, squaredNumber);

		/*
		Assignment Instructions
		For this assignment, write a C# program that has several simple functions:
		*/


		
		// DisplayWelcome - Displays the message, "Welcome to the Program!"
		static void DisplayWelcome()
		{
		  Console.WriteLine("Welcome to the Program!");
		}

		// PromptUserName - Asks for and returns the user's name (as a string)
		static string PromptUserName()
		{
		  Console.Write("What is your name? ");
		  string name = Console.ReadLine();

		  return name;
		}

		// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
		static int PromptUserNumber()
		{
		  Console.Write("What is your favorite number? ");
		  string numberInput = Console.ReadLine();
		  int number = (int) numberInput;

		  return number;
		}

		// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
		static int SquareNumber(int number)
		{
		  squareNumber = number * number;

		  return squareNumber;
		}

		// DisplayResult - Accepts the user's name and the squared number and displays them.
		static void DisplayResult()
		{
		  string userName = PromptUserName();
		  int usernumber = PromptUserNumber();
		  int squareNumber = SquareNumber(userNumber);

		  Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
		}
		


		/*
		Your Main function should then call
		each of these functions saving the
		return values and passing data to
		them as necessary.

		Sample output of the program could look as follows:


		Welcome to the program!
		Please enter your name: Brother Burton
		Please enter your favorite number: 42
		Brother Burton, the square of your number is 1764
		Write and Test the program
		Write and test the program as described above.
		Make sure to use the same project template that you did for the previous activities. However, this time, you should add your code in Program.cs file in the the Exercise5 project.

		*/
	}

	/*
	// DisplayWelcome - Displays the message, "Welcome to the Program!"
	static void DisplayWelcome()
	{
		Console.WriteLine("Welcome to the Program!");
	}

	// PromptUserName - Asks for and returns the user's name (as a string)
	static string PromptUserName()
	{
		Console.Write("What is your name? ");
		string name = Console.ReadLine();

		return name;
	}

	// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
	static int PromptUserNumber()
	{
		Console.Write("What is your favorite number? ");
		string numberInput = Console.ReadLine();
		int number = Convert.ToInt32(numberInput);

		return number;
	}

	// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
	static double SquareNumber(int number)
	{
		double squareNumber = number * number;

		return squareNumber;
	}

	// DisplayResult - Accepts the user's name and the squared number and displays them.
	static void DisplayResult()
	{
		string userName = PromptUserName();
		int userNumber = PromptUserNumber();
		double squaredNumber = SquareNumber(userNumber);
		
		Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
	}

	static void DisplayResult2(string userName, double squaredNumber)
	{
		Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
	}
	*/

}
