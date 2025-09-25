using System;

class Program
{
	static void Main()
	{
		int count = 0;
		int number = 1;

		while (count < 10001)
		{
			number++;
			if (asalmila(number))
			{
				count++;
				Console.WriteLine("asal sayı FOUNDEDDDDDDD ");

			}
			Console.WriteLine("asal sayı: " + number);

		}

		Console.WriteLine("bittiiiiiiiiiiiiiiiiiiiiiiiiiiii" + number);
	}

	static bool asalmila(int n)
	{
		if (n < 2)
			return false;

		for (int i = 2; i <= Math.Sqrt(n); i++)
		{
			if (n % i == 0)
				return false;
		}

		return true;

	}
}