//Actually this problem is very simple but if someone (like me) can't solve it in an hour I should use the dictionary in C#.

using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(YollariHesapla(20, 20));
		Console.ReadKey();
	}

	static Dictionary<(int, int), long> memory = new Dictionary<(int, int), long>();

	static long YollariHesapla(int en, int boy)
	{
		if (en == 0 || boy == 0)
			return 1;

		if (memory.ContainsKey((en, boy)))
			return memory[(en, boy)];

		long sonuc = YollariHesapla(en - 1, boy) + YollariHesapla(en, boy - 1);
		memory[(en, boy)] = sonuc;
		return sonuc;
	}
}
