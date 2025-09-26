int c = 1;
for (int a = 1; a <= 332; a++)
{
	for (int b = a + 1; b < 600; b++)
	{
		c = 1000 - b - a;
		if ((a * a) + (b * b) == (c * c))
		{
			Console.WriteLine("bitti abi " + a + " " + b + " " + c);
		}

	}

}
//have fun guys