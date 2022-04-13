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
            "Lütfen İsim Giriniz        :",
            "Lütfen Soy İsim Giriniz    :",
            "Lütfen Numara Giriniz      :"
        };
        public static void SecimYap(int value){
            Rehber rehber = new Rehber();
            switch (value)
            {
                    case 1:
                        Rehber.Ekle();
                        break;
                    /*case 2:
                        KayıtSil();
                        break;
                    case 3:
                        KayıtGüncelle();
                        break;
                    case 4:
                        KayıtListele();
                        break;
                    case 5:
                        AramaYap();
                        break;*/
                    default:
                        Console.WriteLine("Value değerinde hata var");
                        break;
            }      
        }
    }
}