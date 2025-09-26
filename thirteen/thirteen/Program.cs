using System.Numerics;

//yeah as usual i did solve problem the rought way lol 

using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

string text = File.ReadAllText("C:\Users\mehme\Desktop\sayilar.txt").Trim();
List<string> numbers = new List<string>();
for (int i = 0; i < text.Length; i += 50)
{
	string part = text.Substring(i, 50);
	numbers.Add(part);
}
BigInteger toplam = 0;
foreach (var item in numbers)
{
	toplam += BigInteger.Parse(item);
}

Console.WriteLine(toplam);