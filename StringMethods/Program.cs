

string degisken ="Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "Dersimiz CSharp";
// Lenght
Console.WriteLine(degisken.Length); // 29

// ToUpper, ToLower
Console.WriteLine(degisken.ToUpper()); // DERSİMİZ CSHARP, HOŞGELDİNİZ!
Console.WriteLine(degisken.ToLower()); // dersimiz csharp, hoşgeldiniz!

//Concat
Console.WriteLine(String.Concat(degisken," Merhaba")); // Dersimiz CSharp, Hoşgeldiniz! Merhaba

// Compare, CompareTo
// eşit olursa 0, 1. değişken 2.değişkenden daha çok karaktere sahipse 1, değilse -1
Console.WriteLine(degisken.CompareTo(degisken2)); // 1
// true,false : Büyük küçük harf duyarlılığı
Console.WriteLine(String.Compare(degisken, degisken2,true)); // false 

// Contains , EndWith , StartWith
// içeriyor mu
Console.WriteLine(degisken.Contains(degisken2)); // true 
// bitiyor mu
Console.WriteLine(degisken.EndsWith("Merhaba")); // true
// başlıyor mu
Console.WriteLine(degisken.StartsWith("Dersimiz")); // false

// IndexOf , LastIndexof
Console.WriteLine(degisken.IndexOf("CS")); // 9 
Console.WriteLine(degisken.LastIndexOf("i")); // 26 en sondaki i indexi 

// Insert
Console.WriteLine(degisken2.Insert(0,"AAA ")); //AAA Dersimiz Csharp

// PadLeft, PadRight
Console.WriteLine(degisken2.PadLeft(30));       //                 Dersimiz CSharp
Console.WriteLine(degisken2.PadLeft(30,'*'));   //***************Dersimiz CSharp
Console.WriteLine(degisken2.PadRight(30,'*'));  //Dersimiz CSharp***************

// Remove
Console.WriteLine(degisken.Remove(10));//Dersimiz C
Console.WriteLine(degisken.Remove(5,3));//Dersi CSharp, Hoşgeldiniz!
Console.WriteLine(degisken.Remove(0,1));//ersimiz CSharp, Hoşgeldiniz!

// Replace
Console.WriteLine(degisken.Replace("CSharp","C#"));//Dersimiz C#, Hoşgeldiniz! 
Console.WriteLine(degisken.Replace(" ","*"));//Dersimiz*CSharp,*Hoşgeldiniz!

// Split
Console.WriteLine(degisken.Split(' ')[1]); //CSharp,

// SubString
Console.WriteLine(degisken.Substring(4,6)); //imiz C

 





