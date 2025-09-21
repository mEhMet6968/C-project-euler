using System;

class Program
{
	static void Main()
	{
		int limit = 4000000;
		int a = 1, b = 2;
		int sum = 0;

		while (b <= limit)
		{
			if (b % 2 == 0)
				sum += b;

			int temp = a + b;
			a = b;
			b = temp;
		}

		Console.WriteLine(sum); // 4613732
	}
}
