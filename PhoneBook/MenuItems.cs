namespace PhoneBook
{
    public static class MenuItems
    {
        public static string[] menuler ={
            "1. Kayıt Ekle",
            "2. Kayıt Sil",
            "3. Kayıt Güncelle",
            "4. Rehberi Listele",
            "5. Rehberde Arama Yap"
        };
        public static string[] ogeler={
            "Lütfen İsim Giriniz        : ",
            "Lütfen Soy İsim Giriniz    : ",
            "Lütfen Numara Giriniz      : "
        };
        public static void SecimYap(int value){
            Rehber rehber = new Rehber();
            switch (value)
            {
                    case 1:
                        Rehber.KayıtEkle();
                        break;
                    case 2:
                        Rehber.KayıtSil();
                        break;
                    case 3:
                        Rehber.KayıtGüncelle();
                        break;
                    case 4:
                        Rehber.Listele();
                        break;
                    case 5:
                        Rehber.KayıtBul();
                        break;
                    default:
                        Console.WriteLine("Value değerinde hata var");
                        break;
            }      
        }
    }
}