using System;

namespace MethodOverloading{
    class Program{
        public static void Main(string[] args){
            // out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi); 
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }


            // out parametreler
            Methodlar methodlar = new Methodlar();
            methodlar.Topla(2,3,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            // method overloading
            
            int ifade = 9999;
            methodlar.EkranaYazdir(Convert.ToString(ifade));
            methodlar.EkranaYazdir(ifade);
            methodlar.EkranaYazdir("Ayşe"+" Ahmet");


        }
    }
}

class Methodlar{
    public void Topla(int a, int b, out int toplam){
        toplam = a+b;
    }
    public void EkranaYazdir(string str){
        Console.WriteLine(str);
    }
    public void EkranaYazdir(int str){
        Console.WriteLine(str);
    }
    public void EkranaYazdir(string str, string str2){
        Console.WriteLine(str + str2);
    }
    
}
