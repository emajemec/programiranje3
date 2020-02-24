<Query Kind="Statements" />

Console.WriteLine("Vnesi mali znak: ");
char z = char.Parse(Console.ReadLine());
Console.WriteLine(z);
Console.WriteLine((char)(z - 'a' + 'A'));