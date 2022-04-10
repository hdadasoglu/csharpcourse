using System;

namespace ConstuctorMethods{
    class Program{
        public static void Main(string[] args){
            // calisan1 nesnesi, parametreleri yazılarak oluşturuluyor 
            Calisan calisan1 = new Calisan(
                "Ayşe",
                "Kara",
                "İnsan Kaynakları",
                100001
            );
            // calisan 2 nesnesi oluşturduktan sonra parametreleri yazılıyor
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.SoyAd = "Arda";
            calisan2.No = 100002;
            calisan2.Departman = "Proje";
            // calisan 3 nesnesi, sadece isim ve soyisim alan overload method sayesinde oluşturuluyor
            Calisan calisan3 = new Calisan(
                "Zikriye",
                "Ürkmez"
            );
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****");
            calisan2.CalisanBilgileri();
            Console.WriteLine("*****");
            calisan3.CalisanBilgileri();
            
        }
    }
    class Calisan
    {
        public string? Ad;
        public string? SoyAd;
        public string? Departman;
        public int No;
        // Calisan methodunu boş bir şekilde de kullanabiliriz parametre girerek de kullanabiliriz
        public Calisan(){}
        public Calisan(string ad,string soyad,string departman,int no){
            this.Ad = ad;
            this.SoyAd = soyad;
            this.Departman = departman;
            this.No = no;
        }
        // Overload ederek bazı parametreler olmadan da oluşturabiliriz eksik parametreler null veya sıfır olarak dönüş yapar ama biz kontrol edebiliriz (bknz Line 50,51).
        public Calisan(string ad,string soyad){
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = -1;  
            this.Departman = "Departman seçilmedi";
        }
        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan adı : {0}",Ad);
            Console.WriteLine("Çalışan soyadı : {0}",SoyAd);
            Console.WriteLine("Çalışan numarası : {0}",No);
            Console.WriteLine("Çalışanın departmanı : {0}",Departman);
        }
    }
}