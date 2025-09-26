

long n = 10000;
while (true)
{
	int sayac = 0;
	long triangular = n * (n + 1) / 2;
	Console.WriteLine($"T_{n} = {triangular}");
	for (int i = 1; i < triangular; i++)
	{
		if (triangular % i == 0)
		{
			sayac++;
		}
		if (sayac > 500)
		{
			Console.WriteLine("Bulduk laaa" + triangular);
			break;
		}
	}
	n++;
	sayac = 0;


}
