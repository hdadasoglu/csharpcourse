using System;

namespace Encapsulation{
    class Program{
        public static void Main(string[] args){

            Ogrenci ogrenci1 = new Ogrenci("Ahmet","Mümtaz",1,100001);
            
            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Ad = "Lale";
            
            Console.WriteLine(ogrenci1.Ad); // Ad propertysini kullanarak dolaylı olarak private olan ad fieldini çağırabildik. Ad propertysinin get fonksiyonu olmasaydı bu işlemi yapamazdık.
            Console.WriteLine(ogrenci1.SoyAd);
            Console.WriteLine(ogrenci1.OgrenciNo);
            Console.WriteLine(ogrenci1.Sinif);
            
            Console.WriteLine("*******************");
            ogrenci1.SınıfAzalt();
            Console.WriteLine("*******************");
            ogrenci1.OgrenciYazdir();
            Console.WriteLine("*******************");
            ogrenci2.OgrenciYazdir();
            
        }
    }

    class Ogrenci{
        //fields
        private string? ad;
        private string? soyAd;
        private int sinif;
        private int ogrenciNo;
        
        // properties
        public string? Ad // bu propertiye gelen değer valuede tutulur
        { 
            get{
                return ad; // private olan ad fieldini (Line : 23), get sayesinde Ad propertisiyle çağrılabilir.
            }
            set{
                ad = value; // valueye gelen değer private olan ad parametresine kaydedilir.
            } 
        }
        public string? SoyAd { get => soyAd; set => soyAd = value; }
        public int Sinif { get => sinif; 
            set{
                // dışarıdan gelen değer sadece 0 dan büyükse Classın sinif fieldine yazılır aksi takdirde yazılmaz.
                if(value>0)
                    sinif = value;
                else
                    Console.WriteLine("Sınıf 1 den küçük olmaz");
            } 
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        // constructors
        public Ogrenci(string ad, string soyAd, int sinif, int ogrenciNo)
        {
            Ad = ad; // ad : Ogrenci constructorına gelen parametredir.(string ad,) 
                    //  Ad : propertidir eşitleme yapıldığı anda Ad propertisi çalışır (Line : 29). 
            SoyAd = soyAd;
            Sinif = sinif;
            OgrenciNo = ogrenciNo;
        }
        public Ogrenci(){
        }
        // Methods
        public void SınıfArttır(){
            Sinif++; // Sinif propertsinin set fonksiyonuna gider.
        }
        public void SınıfAzalt(){
            Sinif--; // Sinif propertsinin set fonksiyonuna gider.
        }
        public void OgrenciYazdir(){
            Console.WriteLine("Öğrencinin adı       : {0}",Ad);
            Console.WriteLine("Öğrencinin soyadı    : {0}",SoyAd);
            Console.WriteLine("Öğrencinin numarası  : {0}",OgrenciNo);
            Console.WriteLine("Öğrencinin sınıfı    : {0}",Sinif);
        }
    }
}