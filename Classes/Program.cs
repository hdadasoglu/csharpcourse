using System;

namespace Classes{
    class Program{
        public static void Main(string[] args){
            // erişim belirleyiciler
            // public   :   Her yerden erişilebilir
            // private  :   Sadece tanımlandığı sınıf içerisinde erişilebiilir
            // internal :   Sadece bulunduğu proje içerisinde erişilebilir
            // protected:   Sadece tanımlandığı sınıfta veya miras alan sınıflarda kullanılabilir

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.SoyAd = "Kara";
            calisan1.No = 100001;
            calisan1.Departman = "İnsan Kaynakları";
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.SoyAd = "Arda";
            calisan2.No = 100002;
            calisan2.Departman = "Proje";

            calisan1.CalisanBilgileri();
            Console.WriteLine("*****");
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string? Ad;
        public string? SoyAd;
        public string? Departman;
        public int No;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan adı : {0}",Ad);
            Console.WriteLine("Çalışan soyadı : {0}",SoyAd);
            Console.WriteLine("Çalışan numarası : {0}",No);
            Console.WriteLine("Çalışanın departmanı : {0}",Departman);
        }
    }
}