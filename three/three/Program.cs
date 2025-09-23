using System;

class Program
{
	static void Main()
	{
		long number = 600851475143;
		long factor = 2;
		long largest = 0;

		while (number > 1)
		{
			if (number % factor == 0)
			{
				largest = factor;
				number /= factor;
				while (number % factor == 0)
					number /= factor;
			}
			factor++;
		}

		Console.WriteLine(largest); // 6857
	}
}
