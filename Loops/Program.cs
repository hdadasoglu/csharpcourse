using System;

namespace Loops
{
    class Program
    {
        static void Main (string[] args)
        {
            // Konsoldan girilen sayıya kadar olan tek sayıları yazdırma
            Console.WriteLine("Lütfen bir sayı giriniz");

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<n;i++){
                if(i%2!=0){
                    Console.WriteLine(i+" ");
                }
            }
            
            // 1 den 1000'e kadar tek ve çift sayıları ayrı ayrı topla yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }
            Console.WriteLine("Tek toplam :" + tekToplam);
            Console.WriteLine("Çift Toplam :" + ciftToplam);

            // Break ve Continue 
            // Output : 0 1 2 3
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            } 
            // Output : 0 1 2 3 5 6 7 8 9
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }

            // While

            // Consoldan girilen sayıya kadar olan sayıların ortalamasını al
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi){
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a'dan z'ye kadar olan sayıları yazdır
            char c = 'a';
            while(c<='z'){
                Console.Write(c);
                c++;
            }

            // ForEach

            string[] arabalar = {"Volvo","Bwm","Mercedes","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}   