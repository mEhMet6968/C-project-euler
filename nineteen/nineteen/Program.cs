int count = 0;
int dow = 1; //0 pazar 6 cumartesi
List<int> aylar = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
for (int year = 1901; year <= 2000; year++)
{
	if (artıkyılmı(year) == true)
	{
		aylar[1] = 29;
	}
	if (artıkyılmı(year) != true)
	{
		aylar[1] = 28;
	}
	for (int month = 1; month <= 12; month++)
	{
		if (dow == 0)
		{
			count++;
		}
		for (int i = 0; i <= aylar[(int)month - 1]; i++)
		{
			dow++;
			if (dow % 7 == 0)
			{
				dow = dow - 7;
			}
			dow = (dow + aylar[month - 1]) % 7;
		}
	}
}
Console.WriteLine(count);
bool artıkyılmı(int year)
{
	if (year % 400 == 0) return true;
	if (year % 100 == 0) return false;
	return year % 4 == 0;
}