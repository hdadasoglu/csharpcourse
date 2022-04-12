using System;

namespace OOP{
    public class Program{
        public static void Main(string[] args){
            
            Console.WriteLine("***Tohumlu Bitki***");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler(); // tohumlu bitkiler çağırıldığında kendi constructorunun içerisindeki tüm methodlar çalışır.
            tohumluBitki.TohumlaÇoğalma();

            Console.WriteLine("***Martı***");
            Kuslar marti = new Kuslar(); // Kuslar çağırıldığında kendi constructorunun içerisindeki tüm methodlar çalışır.
            marti.Uçmak();      // Kendi sınıfından
            marti.Adaptasyon(); // hayvanlar sınıfından
        }
    }
}