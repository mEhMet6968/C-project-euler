int toplam = 0;

int makul = 0;

int carpim = 1;

List<int> number = new List<int>() { };

for (int i = 1; i <= 100; i++)

{

	toplam = i + toplam;

}

for (int l = 0; l <= 100; l++)

{

	number.Add(l * l);

}

foreach (int sayi in number)

{

	makul += sayi;

}

Console.WriteLine(makul);

Console.WriteLine(toplam * toplam);

Console.WriteLine("İstenen Cevap " + ((toplam * toplam) - makul));