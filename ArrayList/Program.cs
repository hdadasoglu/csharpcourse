using System.Collections;

ArrayList liste = new ArrayList();

liste.Add("Ayşe");
liste.Add('c');
liste.Add(true);
liste.Add(2);
liste.Add(2.3454353);

Console.WriteLine(liste[3]);
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//AddRange
Console.WriteLine("***** Add Range ********");
string[] renkler = {"Kırmızı","Sarı","Yeşil","Mor"};
List<int> sayilar = new List<int>(){3,6,35,5464,234};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Sort
Console.WriteLine("***** Sort ******");
liste.Sort(); // runtimeda hata verir farklı tipdeki değişkenleri sıralamayaz 

// BinarySearch
Console.WriteLine("***** Binary Search ******");
liste.BinarySearch(9);

// Reverse
Console.WriteLine("***** Reverse ******");
liste.Reverse();

// Clear
liste.Clear();