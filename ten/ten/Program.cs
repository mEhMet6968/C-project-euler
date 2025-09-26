List<int> number = new List<int>();
long valueeee = 0;

for (int i = 2; i < 2000000; i++)
{
	bool isPrime = true;
	for (int a = 2; a * a <= i; a++)
	{
		if (i % a == 0)
		{
			isPrime = false;
			break;
		}
	}
	if (isPrime)
	{
		number.Add(i);
	}
}

foreach (int i in number)
{
	valueeee += i;
}

Console.WriteLine(valueeee);