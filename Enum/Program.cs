using System;

namespace Enum{
    class Program{
        public static void Main(string[] args){
            int sıcaklık = 17;

            if(sıcaklık<=(int)HavaDurumu.Soguk)
                Console.WriteLine("Hava Soğuk");
            else if(sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Hava Normal");
            else if(sıcaklık<=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Hava Sıcak");
            else if(sıcaklık<=(int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hava Çook Sıcak");
            else
                Console.WriteLine("Hata");
        }
    }
    enum HavaDurumu{
        Soguk = 15,
        Normal = 25,
        Sıcak = 30,
        ÇokSıcak = 40
    }
}