using System.Numerics;

//my solition(i forget its name) but i can say we starting calculate from top of the bottom side and pick a number bottom of this side we have two staticts for sum code try of them and which calculate bigger than other pick it after we should peak 2 side up
//(yeah i love biginteger its not must)
using System;
using System.Numerics;

class Program
{
	static void Main()
	{
		BigInteger[][] triangle = new BigInteger[][] {
				new BigInteger[]{75},
			new BigInteger[]{95, 64},
			new BigInteger[]{17, 47, 82},
			new BigInteger[]{18, 35, 87, 10},
			new BigInteger[]{20, 04, 82, 47, 65},
			new BigInteger[]{19, 01, 23, 75, 03, 34},
			new BigInteger[]{88, 02, 77, 73, 07, 63, 67},
			new BigInteger[]{99, 65, 04, 28, 06, 16, 70, 92},
			new BigInteger[]{41, 41, 26, 56, 83, 40, 80, 70, 33},
			new BigInteger[]{41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
			new BigInteger[]{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
			new BigInteger[]{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
			new BigInteger[]{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
			new BigInteger[]{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
			new BigInteger[]{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
		};

		// En alttan yukarıya doğru hesaplama
		for (int i = triangle.Length - 2; i >= 0; i--)
		{
			for (int j = 0; j < triangle.Length; j++)
			{
				// Bir sonraki satırda j ve j+1 indeksleri mevcut olmalı
				if (j + 1 < triangle[i + 1].Length)
				{
					BigInteger sol = triangle[i + 1];
					BigInteger sag = triangle[i + 1][j + 1];
					triangle += (sol > sag) ? sol : sag;
				}
				else
				{
					// Eğer j+1 indeksi yoksa, sadece sol değeri ekle
					triangle += triangle[i + 1];
				}
			}
		}

		Console.WriteLine("Maksimum toplam: " + triangle);
	}
}