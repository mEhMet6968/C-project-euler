int number;
List<int> pal = new List<int>() { };
for (int i = 999; i > 100; i--)
{
	for (int j = 999; j > 100; j--)
	{
		number = i * j;
		string metin = number.ToString();
		char[] karakterler = metin.ToCharArray();
		Array.Reverse(karakterler);
		string tersMetin = new string(karakterler);
		if (metin == tersMetin)
		{
			pal.Add(number);
		}
		int enBuyuk = int.MinValue;
		foreach (int sayi in pal)
		{
			if (sayi > enBuyuk)
			{
				enBuyuk = sayi;
			}
		}
		Console.WriteLine("En büyük sayı: " + enBuyuk);
	}
}
