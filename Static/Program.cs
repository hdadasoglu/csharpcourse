using System;

namespace Static{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine(Calisanlar.calisanSayisi); // _calisanSayisi fieldi static olduğu için nesne oluşturmadan çağırabildik ve Statik olan bu çalışan sayısı calisan nesnelerin bir özelliği değil class olan Calisanların bir özelliğidir. 
            

            // şimdi biraz calisan oluşturalım
            Calisanlar calisan1 = new Calisanlar("Ayşe","Kaplan","Üretim");
            Console.WriteLine(Calisanlar.calisanSayisi); // çalışan sayısı : 1
            Calisanlar calisan2 = new Calisanlar("Aslı","Ürkmez","Proje");
            Console.WriteLine(Calisanlar.calisanSayisi); // çalışan sayısı : 2

            // Çalışan sayısı private olduğu ve set propertisi olmadığı için dışarıdan değer atanamaz alttaki kod hata verir.    
            // Calisanlar.CalisanSayisi = 2;

            // Static Method
            Calisanlar.StaticYaz();

            // Static Class kullanımı

            // Static sınıfların nesnesi oluşturulmaz ve methodları nesne üzerinden çağıralamaz
            // Islemler islemler = new Islemler();
            // islemler.Topla(10,20);

            // Static sınıfın tüm elemanları (field, property ve method ) staticdir.
            Console.WriteLine(Islemler.Çıkar(10,20)); 
            Console.WriteLine(Islemler.Topla(10,20));
        }
    }
    class Calisanlar{
        // fields
        private static int _calisanSayisi;
        private string? _isim;
        private string? _soyAd;
        private string? _departman;
        // properties
        public static int calisanSayisi { get => _calisanSayisi;} // set fonksiyonu silindiği için çalışan sayısı dışarıdan asla değiştirilemez
        public string? soyAd { get => _soyAd; set => _soyAd = value; }
        public string? departman { get => _departman; set => _departman = value; }
        public string? isim { get => _isim; set => _isim = value; }
        // constructors
        static Calisanlar(){ // burası Calisan clası ilk defa çağırıldığında çalışır.
            _calisanSayisi = 0;
        }
        public Calisanlar(string Isim,string SoyAd,string Departman){
            isim = Isim;
            soyAd = SoyAd;
            departman = Departman;
            Islemler.Topla(_calisanSayisi,1); // Her bir nesne oluşturulduğunda çalışan sayısı bir arttılıyor
        }
        public Calisanlar(){}

        public static void StaticYaz(){
            Console.WriteLine("*********Static*********");
        }
    
    }
    static class Islemler{
        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2; 
        }
        public static int Çıkar(int sayi1,int sayi2){
            return sayi1-sayi2;
        }
    }
}