// deger ve anahtar , anahtarlar eşsiz olmalı
// Generic namespacesi altında bulunuyor
        // key ,value
Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10,"Ayşe Yılmaz");
kullanıcılar.Add(12,"Ahmet Yılmaz");
kullanıcılar.Add(9,"Ayşenur ");
kullanıcılar.Add(11,"Özcan Çoşar");

// Elemanlara erişim

Console.WriteLine(kullanıcılar[12]);
Console.WriteLine(kullanıcılar[3]);

foreach (var item in kullanıcılar)
{
    Console.WriteLine(item.Value);
    Console.WriteLine(item.Key);
    Console.WriteLine(item);
}

// Count

Console.WriteLine(kullanıcılar.Count);

// Contains

Console.WriteLine(kullanıcılar.ContainsKey(12));
Console.WriteLine(kullanıcılar.ContainsValue("Ayşenur "));

// Eleman çıkarma
                  //key
kullanıcılar.Remove(12);

// Keys ve Values


foreach (var item in kullanıcılar.Keys)
{
    Console.WriteLine(item);
}
foreach (var item in kullanıcılar.Values)
{
    Console.WriteLine(item);
}