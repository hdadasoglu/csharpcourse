using System;

namespace OOP{
    public class Program{
        public static void Main(string[] args){
            
            Console.WriteLine("***Tohumlu Bitki***");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler(); // tohumlu bitkiler çağırıldığında kendi constructorunun içerisindeki tüm methodlar çalışır.
            //tohumluBitki.Beslenme(); // canlı sınıfından geldi
            //tohumluBitki.Fotosentez();// bitki sınıfından protected method, sınıf türetildiğinde çalışır
            //tohumluBitki.Bosaltım();   // canlı sınıfından 
            tohumluBitki.TohumlaÇoğalma(); // kendi sınıfından

            Console.WriteLine("***Martı***");
            Kuslar marti = new Kuslar();
            marti.Uçmak();      // Kendi sınıfından
            marti.Adaptasyon(); // hayvanlar sınıfından
            //marti.Bosaltım();   // Canlı sınıfından
            //marti.Solunum();     // Canlı sınıfından*/
        }
    }
}