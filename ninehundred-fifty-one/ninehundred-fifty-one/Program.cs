using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
	static void Main()
	{
		BigInteger nBig = 0; 
		int nInt = 0; 
		Console.WriteLine("n=?");
		string input = Console.ReadLine();
		// input parsing to biginteger
		if (int.TryParse(input, out nInt) && BigInteger.TryParse(input, out nBig))
		{
			BigInteger toplam = Factorial(2 * nBig) / (Factorial(nBig) * Factorial(nBig));
			Console.WriteLine($"Toplam {2 * nBig} elemanlı ({nBig} sıfır, {nBig} bir) kısıtsız dizilim sayısı: {toplam}");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Kurala uymayan (içinde 2'li segment olmayan) desteler hesaplanıyor...");
			BigInteger[,] F = new BigInteger[nInt + 1, nInt + 1];
			F[0, 0] = 1;//this line is important for DP base case
			// DP tab add
			for (int n = 1; n <= nInt; n++)
			{
				for (int k = 1; k <= n; k++) 
				{
					F[n, k] += F[n - 1, k - 1];
					for (int x = 3; x <= n; x++)// out of 2 
					{
						F[n, k] += F[n - x, k - 1];
					}
				}
			}
			BigInteger kotuDesteler = 0;
			for (int k = 1; k <= nInt; k++)
			{
				kotuDesteler += 2 * F[nInt, k] * F[nInt, k];
				//this line out of if because we should calculete 2 more kotuDesteler.
				if (k + 1 <= nInt)
				{
					kotuDesteler += 2 * F[nInt, k + 1] * F[nInt, k];
				}
			}
			BigInteger adilDesteler = toplam - kotuDesteler;
			Console.WriteLine(adilDesteler);
		}
		else
		{
			Console.WriteLine("Geçersiz sayı girdiniz.");
		}
		Console.WriteLine("\nProgram sonlandı. Çıkmak için bir tuşa basın.");
		Console.ReadKey();
	}
	static BigInteger Factorial(BigInteger n)
	{
		BigInteger result = 1;
		for (int i = 2; i <= n; i++)
			result *= i;
		return result;
	}
}