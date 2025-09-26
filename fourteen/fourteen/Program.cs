//this is my c# solition i read other solitions and i said "i should learn assembly"

class Program
{
	static void Main(string[] args)
	{
		long enbuyuk = 0;
		int hangi = 0;
		for (int i = 2; i <= 1000000; i++)
		{
			long x = i;
			int sayac = 0;

			while (x != 1)
			{
				if (x % 2 == 0)
					x = even(x);
				else
					x = odd(x);

				sayac++;

			}
			if (sayac > enbuyuk)
			{
				enbuyuk = sayac;
				hangi = i;
			}


		}
		Console.WriteLine($"most longest: {hangi} ({enbuyuk} step)");

	}

	static long odd(long x)
	{
		return 3 * x + 1;
	}

	static long even(long x)
	{
		return x / 2;
	}
}