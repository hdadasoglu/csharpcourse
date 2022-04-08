// <List> Class
// System.Collection.Generic 
// T-> obje türündedir bu bir nesne alabilir 

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(12);
sayiListesi.Add(34);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(35);

List<string> renkListesi = new List<string>();

renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

// Count
Console.WriteLine(renkListesi.Count());
Console.WriteLine(sayiListesi.Count());

// foreach ve list foreach
foreach (var item in sayiListesi)
    Console.WriteLine(item);
foreach (var item in renkListesi)
    Console.WriteLine(item);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Listeden eleman çıkarma
sayiListesi.Remove(5);
renkListesi.Remove("Yeşil");

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(0);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Liste içerisinde arama
Console.WriteLine(sayiListesi.Contains(13)? "Listede mevcut" : "Listede yok"); // true, false

// Liste içerisinde elemana erişme
renkListesi.Sort();
Console.WriteLine(renkListesi.BinarySearch("Mavi"));//Binary Search için her bir eleman eşsiz ve liste sıralı olmalı

// Diziyi listeye çevirme
string[] hayvanlar = {"Kedi","Pirana","Kaplan"};
List<string> hayvanList = new List<string>(hayvanlar);

// Listeyi temizlemek
hayvanList.Clear();

// Liste içerinde nesne tutmak
// nesneleri oluşturuyoruz
Kullanıcılar kullanici1 = new Kullanıcılar();
Kullanıcılar kullanici2 = new Kullanıcılar();
kullanici1.Isim="Ahmet";
kullanici1.Soyisim="Yılmaz";
kullanici1.Yas = "25";

kullanici2.Isim="Ayşe";
kullanici2.Soyisim="Yılmaz";
kullanici2.Yas = "26";

List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

// yeni bir liste oluşturalım

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar(){
    Isim = "Deniz",
    Soyisim= "Arda",
    Yas="22"
});

yeniListe.Add(new Kullanıcılar(){
    Isim = "Deniza",
    Soyisim= "Ardaa",
    Yas="223"
});

foreach (Kullanıcılar kullanıcı in kullaniciListesi)
{
    Console.WriteLine("Kullanıcı adı : "+kullanıcı.Isim);
    Console.WriteLine("Kullanıcı soyadı : "+kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı yaşı : "+kullanıcı.Yas);
}
foreach (Kullanıcılar kullanıcı in yeniListe)
{
    Console.WriteLine("Kullanıcı adı : "+kullanıcı.Isim);
    Console.WriteLine("Kullanıcı soyadı : "+kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı yaşı : "+kullanıcı.Yas);
}
public class Kullanıcılar{
    // bu değişkenler private'dır. private değişkenler dışarıya açılmaz
    string isim;  
    string soyisim;
    string yas;


    public string Yas { get => yas; set => yas = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public string Isim { get => isim; set => isim = value; }
}