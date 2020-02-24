<Query Kind="Program" />

void Main()
{
	Console.Write("Vnesi niz: ");
	string niz = Console.ReadLine();
	string ob_niz = "";
	int ind = 0;
	while (ind < niz.Length)
	{
		ob_niz = niz[ind] + ob_niz;
		ind++;
	}
	Console.WriteLine(niz + " : " + ob_niz);
	
}