using System.Collections;
using System;
//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.

public class Operation{
  
    // Bir listenin içindeki asal ve asal olmayan olan sayıları döndürür parametre olarak true gönderilirse asal olanları false gönderilirse asal olmayans sayıları döndürür
    public ArrayList Ayır(ArrayList sayilar,bool wantPrime){
        ArrayList sayiListesi = new ArrayList(); // yeni bir array list tanımı
        
        bool isDivide = false;
        foreach (var item in sayilar)
        {
            if((int)item == 1)
            {
                isDivide = true;
            }
            else if((int)item == 2)
            {
                isDivide = false;
            }
            else
            {
                for(int i = 2; i < (int)item ;i++)
                {
                    // item kendine kadar olan herhangi bir sayıya bölünürse bir sonraki iteme bakılıyor
                    if((int)item%i==0)
                    {
                        isDivide = true;
                        break;
                    }
                    else
                    {
                        isDivide = false;        
                    }
                }
            }
            // eğer item kendine kadar olan bir sayıya bölündüyse ve asal olan sayılar istenmiyorsa listeye eklenir
            if(wantPrime == true && !isDivide){
                sayiListesi.Add(item);
            }else if(wantPrime == false && isDivide)
                sayiListesi.Add(item);
        }
        // wantPrime true olursa asal olanları herhangi bir seçim yapılmazsa veya false seçilirse asal olmanları dönürürür.
        return sayiListesi;
    }

    public void TersSiralaYazdir(ArrayList list){
        list.Sort();
        list.Reverse();
        Console.Write("\n[");
        foreach (var item in list)
        {   
            Console.Write(" "+item+" ");
        }
        Console.Write("]");
    }
}


namespace PrimeNumbers{
    class Program{
        public static void Main(string[] args){
            ArrayList sayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            //Console.Write("Kaç adet sayı gireceksiniz : ");
            //int sayac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 20 adet Sayı Giriniz");

            int i = 0;

            while (i < 20)
            {
                // Alınan değerler sayı değilse program devam ediyor
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
                    sayilar.Add(a);
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz");
                }
            }

            for(int j = 0; j<1 ;j++){
                Console.WriteLine("aa");
            }

            Operation operation = new();
            // listeler alınıyor
            asalSayilar = operation.Ayır(sayilar,true);
            asalOlmayanSayilar = operation.Ayır(sayilar,false);
            // listeler yazdırılıyor
            Console.Write("\nAsal olan sayılar : ");
            operation.TersSiralaYazdir(asalSayilar);
            Console.Write("\nAsal olmayan sayılar : ");
            operation.TersSiralaYazdir(asalOlmayanSayilar);


        }
    }
}



