using System;

namespace Arrays
{
   class Program{
       static void Main(string[] args){
           // Dizi tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            // Klavyeden girilen n tane sayının ortalamasını almak
            Console.Write("Dizinin eleman sayısı : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];

            for(int i = 0; i<n;i++)
            {
                Console.Write("Lütfen dizinin {0}. sayını giriniz : ",i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            Console.WriteLine("Ortalama : {0}",toplam/n);
       }
   }
}