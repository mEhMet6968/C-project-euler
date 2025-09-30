//i am so lazy i was find 100! value and run this code
using System;

class Program
{
	static void Main()
	{
		string number = "100!";

		int sum = 0;
		foreach (char c in number)
		{
			sum += c - '0';
		}

		Console.WriteLine("sum: " + sum);
	}
}