using System;
using System.Collections;
public static class Helper{
    public static double Ortalama(this ArrayList list){
        int toplam = 0;
        double ortalama = 0;
        foreach (var item in list)
        {
            toplam+=(int)item;
        }
        try
        {
            ortalama = toplam/list.Count;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0");
        }
        return ortalama;
    }
    /*public static void ListeYazdir(this ArrayList list){
        Console.Write("\n[");
        foreach (var item in list)
        {   
            Console.Write(" "+item+" ");
        }
        Console.Write("]");
    }*/
}

//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

namespace HighestLowest{
    class Program{
        public static void Main(string[] args){
            ArrayList numberList = new ArrayList();
            ArrayList lowestList = new ArrayList();
            ArrayList highestList = new ArrayList();
            //Console.Write("Kaç adet sayı gireceksiniz : ");
            //int sayac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 20 adet Sayı Giriniz");

            int i = 0;

            while (i < 20)
            {
                // Alınan değer sayı değilse sayı tekrar isteniyor.
                Console.Write("{0}. sayıyı giriniz ",i+1);
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    
                    // Alınan değer negatifse sayı tekrar isteniyor.
                    if(a <= 0){
                        Console.WriteLine("Lütfen pozitif ve sıfırdan büyük bir sayı giriniz");
                        continue;
                    }
                    // Bir sorun yoksa listeye ekleniyor döngü bir sonraki adıma geçiyor
                    numberList.Add(a);
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz");
                }
            }
            // En küçük 3 tanesinin başka bir listeye aktarılması 
            numberList.Sort();
            lowestList.Add(numberList[0]);            
            lowestList.Add(numberList[1]);            
            lowestList.Add(numberList[2]);
            // En büyük 3 tanesinin başka bir listeye aktarılması
            numberList.Reverse();
            highestList.Add(numberList[0]);            
            highestList.Add(numberList[1]);            
            highestList.Add(numberList[2]);
            //highestList.ListeYazdir();
            //lowestList.ListeYazdir();            
            Console.WriteLine("\nEn büyük 3 tanesinin ortalaması : " + highestList.Ortalama());
            Console.WriteLine("En küçük 3 tanesinin ortalaması : " + lowestList.Ortalama());
            Console.WriteLine("Ortalama Toplamları : "+highestList.Ortalama()+lowestList.Ortalama());
        }
    }
}