using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> sayilar = new List<int>
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
			11, 12, 13, 14, 15, 16, 17, 18, 19, 20
		};

		long carp = 1;
		foreach (int i in sayilar)
		{
			carp *= i;
		}

		int obeb = OBEBListesi(sayilar);
		int okek = OKEKListesi(sayilar);

		Console.WriteLine("Çarpım: " + carp);
		Console.WriteLine("OBEB: " + obeb);
		Console.WriteLine("OKEK: " + okek);
	}

	static int OBEB(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

	static int OBEBListesi(List<int> sayilar)
	{
		int sonuc = sayilar[0];
		for (int i = 1; i < sayilar.Count; i++)
		{
			sonuc = OBEB(sonuc, sayilar[i]);
		}
		return sonuc;
	}

	static int OKEK(int a, int b)
	{
		return a / OBEB(a, b) * b;
	}

	static int OKEKListesi(List<int> sayilar)
	{
		int sonuc = sayilar[0];
		for (int i = 1; i < sayilar.Count; i++)
		{
			sonuc = OKEK(sonuc, sayilar[i]);
		}
		return sonuc;
	}
}
