<Query Kind="Statements" />

int[] tabSt;
tabSt = new int[10];
tabSt[7] = 42;
Console.WriteLine(tabSt[5]);
Console.WriteLine(tabSt[7]);
Console.WriteLine(tabSt);

for (int i = 0; i < tabSt.Length; i++)
	{
		Console.Write(tabSt[i] + ", ");
	}
	Console.WriteLine();