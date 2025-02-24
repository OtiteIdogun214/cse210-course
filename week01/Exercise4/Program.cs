using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise4 Project.");

		/* */

		
		int number = -1;
		
		// append each one to a list. 
		List<int> numberList = new List<int>();
		
		while (number != 0) 
		{
		  // Ask the user for a series of numbers, and
		  Console.Write("Enter number (+ or -): ");
		  string numberInput= Console.ReadLine();
		  number = int.Parse(numberInput); // Or Convert.ToInt32(numberInput) ToInt32 or ToInt64  
		  
		  numberList.Add(number);
		  
		  if (number == 0) 
		  {
		    numberList.Remove(0);
		  }
		}
		
		/*
		Stop when they enter 0. 
		(Remember: You should not add 0 to the list. 
		
		If you do, later calculations and operations 
		will not be correct.)

		Once you have a list, have your program do the following:

		Core Requirements
		Work through these core requirements step-by-step 
		to complete the program. Please don't skip ahead 
		and do the whole thing at once, because others 
		on your team may benefit from building 
		the program up slowly.
		*/

		// Compute the sum, or total, of the numbers in the list.
		int sum = numberList.Sum();
		Console.WriteLine($"Sum of List Numbers = {sum}");
		
		// Compute the average of the numbers in the list.
		float average = ((float) sum) / numberList.Count; // for Arrays us .Length
		Console.WriteLine($"Average of List Numbers = {average}");

		// Find the maximum, or largest, number in the list.
		int maxNum = numberList[0];
		
		foreach (int num in numberList) 
		{
		  if (num > maxNum)
		  {
		    maxNum = num;
		  }
		}
		Console.WriteLine($"Largest Number in List = {maxNum}");


		/*
		The following shows the expected output:


		Enter a list of numbers, type 0 when finished.
		Enter number: 18
		Enter number: 36
		Enter number: 2
		Enter number: 48
		Enter number: 6
		Enter number: 12
		Enter number: 9
		Enter number: 0
		The sum is: 131
		The average is: 18.714285714285715
		The largest number is: 48

		Stretch Challenge
		Have the user enter both positive and negative numbers, then 
		*/
		
		// find the smallest positive number 
		// (the positive number that is closest to zero).
		
		int minPositiveNum = numberList[0];
		
		foreach (int num in numberList) 
		{
		  if (num > 0)
		  {
		    if (num < minPositiveNum) 
		    {
		      minPositiveNum = num;
		    }
		  }
		}
		Console.WriteLine($"Smallest Positive in List = {minPositiveNum}");


		// Sort the numbers in the list and 
		// display the new, sorted list. 
		// Hint: There are C# libraries that 
		// can help you here, try searching 
		// the internet for them.
		numberList.Sort();
		Console.WriteLine($"Sorted Number List:");
		
		foreach (int num in numberList) 
		{
		  Console.WriteLine($"{num}");
		} 

		/*
		The following shows the expected output after completing the stretch challenges:

		*/
	}
}












using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise4 Project.");

		/* */

		
		int number = -1;
		
		// append each one to a list. 
		List<int> numberList = new List<int>();
		
		while (number != 0) 
		{
		  // Ask the user for a series of numbers, and
		  Console.Write("Enter number (+ or -): ");
		  string numberInput= Console.ReadLine();
		  number = int.Parse(numberInput); // Or Convert.ToInt32(numberInput) ToInt32 or ToInt64  
		  
		  numberList.Add(number);
		  
		  if (number == 0) 
		  {
		    numberList.Remove(0);
		  }
		}
		
		/*
		Stop when they enter 0. 
		(Remember: You should not add 0 to the list. 
		
		If you do, later calculations and operations 
		will not be correct.)

		Once you have a list, have your program do the following:

		Core Requirements
		Work through these core requirements step-by-step 
		to complete the program. Please don't skip ahead 
		and do the whole thing at once, because others 
		on your team may benefit from building 
		the program up slowly.
		*/

		// Compute the sum, or total, of the numbers in the list.
		int sum = numberList.Sum();
		Console.WriteLine($"Sum of List Numbers = {sum}");
		
		// Compute the average of the numbers in the list.
		float average = ((float) sum) / numberList.Count; // for Arrays us .Length
		Console.WriteLine($"Average of List Numbers = {average}");

		// Find the maximum, or largest, number in the list.
		int maxNum = numberList[0];
		
		foreach (int num in numberList) 
		{
		  if (num > maxNum)
		  {
		    maxNum = num;
		  }
		}
		Console.WriteLine($"Largest Number in List = {maxNum}");


		/*
		The following shows the expected output:


		Enter a list of numbers, type 0 when finished.
		Enter number: 18
		Enter number: 36
		Enter number: 2
		Enter number: 48
		Enter number: 6
		Enter number: 12
		Enter number: 9
		Enter number: 0
		The sum is: 131
		The average is: 18.714285714285715
		The largest number is: 48

		Stretch Challenge
		Have the user enter both positive and negative numbers, then 
		*/
		
		// find the smallest positive number 
		// (the positive number that is closest to zero).
		
		int minPositiveNum = numberList[0];
		
		foreach (int num in numberList) 
		{
		  if (num > 0)
		  {
		    if (num < minPositiveNum) 
		    {
		      minPositiveNum = num;
		    }
		  }
		}
		Console.WriteLine($"Smallest Positive in List = {minPositiveNum}");


		// Sort the numbers in the list and 
		// display the new, sorted list. 
		// Hint: There are C# libraries that 
		// can help you here, try searching 
		// the internet for them.
		numberList.Sort();
		Console.WriteLine($"Sorted Number List:");
		
		foreach (int num in numberList) 
		{
		  Console.WriteLine($"{num}");
		} 

		/*
		The following shows the expected output after completing the stretch challenges:

		*/
	}
}

















using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise4 Project.");

		int number = -1;

		// append each one to a list.
		List<int> numberList = new List<int>();

		while (number != 0)
		{
			// Ask the user for a series of numbers, and
			Console.Write("Enter number (+ or -): ");
			string numberInput= Console.ReadLine();
			number = int.Parse(numberInput); // Or Convert.ToInt32(numberInput) ToInt32 or ToInt64

			numberList.Add(number);

			if (number == 0)
			{
				numberList.Remove(0);
			}
		}

		// Compute the sum, or total, of the numbers in the list.
		int sum = numberList.Sum();
		Console.WriteLine($"Sum of List Numbers = {sum}");

		// Compute the average of the numbers in the list.
		float average = ((float) sum) / numberList.Count; // for Arrays us .Length
		Console.WriteLine($"Average of List Numbers = {average}");

		// Find the maximum, or largest, number in the list.
		int maxNum = numberList[0];

		foreach (int num in numberList)
		{
			if (num > maxNum)
			{
				maxNum = num;
			}
		}
		Console.WriteLine($"Largest Number in List = {maxNum}");


		// Find the smallest positive number
		// (the positive number that is closest to zero).

		int minPositiveNum = numberList[0];

		foreach (int num in numberList)
		{
			if (num > 0)  // The positive number that is closest to and greater than zero
			{
				if (num < minPositiveNum)
				{
					minPositiveNum = num;
				}
			}
		}
		Console.WriteLine($"Smallest Positive in List = {minPositiveNum}");


		// Sort the numbers in the list and
		numberList.Sort();
		Console.WriteLine($"Sorted Number List:");

		foreach (int num in numberList)
		{
			// Display the new, sorted list.
			Console.WriteLine($"{num}");
		}
	}
} 
