using System;
using System.Numerics;

public class ZarOlasilik
{
	public static void Main()
	{
		int dortluZarSayisi = 9;  // Peter
		int altiliZarSayisi = 6;  // Colin
								  // Maksimum toplam değer
		int maxToplam = Math.Max(dortluZarSayisi * 4, altiliZarSayisi * 6);

		// Colin'in zar sonuçları (6 zar, 6 yüzlü)
		BigInteger[] colin = new BigInteger[maxToplam + 1];
		Roll(altiliZarSayisi, 6, colin);

		// Peter'ın zar sonuçları (9 zar, 4 yüzlü)
		BigInteger[] peter = new BigInteger[maxToplam + 1];
		Roll(dortluZarSayisi, 4, peter);

		// Toplam kombinasyon sayıları
		BigInteger toplamColin = 0;
		BigInteger toplamPeter = 0;
		for (int i = 0; i <= maxToplam; i++)
		{
			toplamColin += colin[i];
			toplamPeter += peter[i];
		}

		Console.WriteLine($"Colin toplam kombinasyon: {toplamColin} (beklenen: {BigInteger.Pow(6, altiliZarSayisi)})");
		Console.WriteLine($"Peter toplam kombinasyon: {toplamPeter} (beklenen: {BigInteger.Pow(4, dortluZarSayisi)})");

		// Peter'ın kazanma olasılığını hesapla
		decimal peterKazanir = 0;

		for (int peterToplam = 1; peterToplam <= maxToplam; peterToplam++)
		{
			if (peter[peterToplam] == 0) continue;

			// Peter'ın bu toplamından küçük olan tüm Colin toplamları
			BigInteger colinKayip = 0;
			for (int colinToplam = 1; colinToplam < peterToplam; colinToplam++)
			{
				colinKayip += colin[colinToplam];
			}

			// Bu Peter toplamının Colin'e karşı kazanma oranı
			decimal kazanmaOrani = (decimal)colinKayip / (decimal)toplamColin;

			// Peter'ın bu toplamı alma olasılığı ile ağırlıklandır
			peterKazanir += kazanmaOrani * (decimal)peter[peterToplam] / (decimal)toplamPeter;
		}

		Console.WriteLine($"\\nSonuç:");
		Console.WriteLine($"Peter'ın kazanma olasılığı: %{peterKazanir * 100:F7}");
		Console.WriteLine($"Peter'ın kazanma olasılığı: {peterKazanir:F7}");
	}

	// Recursive zar atma - C++ kodunun aynısı
	static void Roll(int zarSayisi, int yuzSayisi, BigInteger[] sonuclar, int toplam = 0)
	{
		// Tüm zarları attık, toplamı say
		if (zarSayisi == 0)
		{
			sonuclar[toplam]++;
			return;
		}

		// Bu zar için tüm olasılıkları dene
		for (int i = 1; i <= yuzSayisi; i++)
		{
			Roll(zarSayisi - 1, yuzSayisi, sonuclar, toplam + i);
		}
	}
}