//this number so big for C# int value i must need Numerics lib

using System.Numerics;

BigInteger output = 1;
BigInteger sum = 0;
for (int i = 0; i < 1000; i++)
{
	output *= 2;
}
while (output > 0)
{
	BigInteger digit = output % 10;
	sum += digit;
	output /= 10;
}
Console.WriteLine(sum);