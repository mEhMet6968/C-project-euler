//in the 40 min ahh im rusted
List<string> sayilar = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
List<string> teens = new List<string> { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
List<string> tens = new List<string> { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

int toplamKarakter = 0;

for (int i = 1; i <= 999; i++)
{
	string result = "";

	if (i < 10)
		result = sayilar[i - 1];
	else if (i < 20)
		result = teens[i - 10];
	else if (i <= 99)
	{
		int tensDigit = i / 10;
		int onesDigit = i % 10;
		result = tens[tensDigit - 2];
		if (onesDigit != 0)
			result += sayilar[onesDigit - 1];
	}
	else
	{
		int hundreds = i / 100;
		int remainder = i % 100;

		result = sayilar[hundreds - 1] + "hundred";

		if (remainder != 0)
		{
			result += "and";

			if (remainder < 10)
				result += sayilar[remainder - 1];
			else if (remainder < 20)
				result += teens[remainder - 10];
			else
			{
				int tensDigit = remainder / 10;
				int onesDigit = remainder % 10;
				result += tens[tensDigit - 2];
				if (onesDigit != 0)
					result += sayilar[onesDigit - 1];
			}
		}
	}

	toplamKarakter += result.Length;
	toplamKarakter += 11; //i dont write for 1000 sum it manuel
}

Console.WriteLine("1-999 arası toplam karakter sayısı: " + toplamKarakter);
