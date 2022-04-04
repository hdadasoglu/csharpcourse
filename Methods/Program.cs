using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //erişim_belirteci geri_dönüş_tipi metod_adı(Parametre Listesi/Arguman)

            int a = 5;
            int b = 8;
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);


            Methods methods = new Methods();
            methods.EkranaYazdir(Convert.ToString(sonuc));
            methods.EkranaYazdir(Convert.ToString(methods.ArttırveTopla(ref a,ref b)));
            Console.WriteLine(a+b);

        }

        static int Topla(int deger1,int deger2){

            return (deger1+deger2);
        }
    }
    class Methods{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public int ArttırveTopla(ref int deger1,ref int deger2){ // değişkenin kopyasını değil kendisini değiştirdi.
            deger1 += 1;
            deger2 += 1;
            return (deger1+deger2);
        }
    }
}