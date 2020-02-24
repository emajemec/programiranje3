<Query Kind="Program" />

void Main()
{
	string beri_niz;
	int koliko_sam = 0;
	Console.WriteLine("Vnesi besedilo: ");
	beri_niz = Console.ReadLine();
	//Štejemo
	
	for (int i = 0; i < beri_niz.Length ; i++) 
	{
		char znak = beri_niz[i];
		if ("aeiouAEIOU".IndexOf(znak) != -1)
		{
			koliko_sam++;
		}
	}
	Console.WriteLine("V besedilu " + beri_niz + " je " + koliko_sam + " samoglasnikov.");
}