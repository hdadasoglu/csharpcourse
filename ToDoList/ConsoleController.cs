using System.Runtime.CompilerServices;

namespace ToDoList
{
    public static class ConsoleController
    {
        
        public static void MenuYazdir(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Boardı Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            MenuSecimiYap();
        }
        public static void MenuSecimiYap(){
            int secim = 0;

            try
            {
                secim = Convert.ToInt32(Console.ReadLine());
                if(secim<1 || secim > 4){
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n***Hatalı Seçim***\n");
            }

            switch (secim)
            {
                case 0:
                    MenuYazdir();
                    break;
                case 1:
                    BoardListele();
                    break;
                case 2:
                    KartEkle();
                    break;
                case 3:
                    KartSil();
                    break;
                case 4:
                    KartTasi();
                    break;
                default:
                    Console.WriteLine("Birşeyler ters gitti");
                    break;
            }
        }

        public static void BoardListele(){
            Console.WriteLine("\n\nTODO Line");
            Console.WriteLine("*****************************");
            if(IsCardEmpty(Status.TODO)){
                foreach (var item in CardsList.cardList.Where(card => card.Status == Status.TODO))
                {
                    KartYazdır(item);
                }
            }
            Console.WriteLine("\n\nIN PROGRESS Line");
            Console.WriteLine("*****************************");
            if(IsCardEmpty(Status.INPROGRESS)){
                foreach (var item in CardsList.cardList.Where(card => card.Status == Status.INPROGRESS))
                {
                    KartYazdır(item);
                }
            }
            Console.WriteLine("\n\nDONE LINE");
            Console.WriteLine("*****************************");
            if(IsCardEmpty(Status.DONE)){
                foreach (var item in CardsList.cardList.Where(card => card.Status == Status.DONE))
                {
                    KartYazdır(item);
                }
            }
            MenuYazdir();
        }
        public static void KartEkle(){
            Cards card = new Cards();
            Console.Write("Başlık Giriniz                                  :");
            card.Title = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            card.Content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            card.Sizes = (Sizes)Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz (ID)                               :");
            card.AssignedPerson = PersonList.IsValid(Convert.ToInt32(Console.ReadLine()));
            if (card.AssignedPerson != null){
                CardsList.cardList.Add(card);
                Console.WriteLine("** Kaydedilen Kart **");
                KartYazdır(card);
            }else{
                Console.WriteLine("** ID numarası hatalı tekrar giriniz **");
                KartEkle();
            }
            MenuYazdir();
        }
        public static void KartSil(){
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz");
            string s = Console.ReadLine();
            if(CardCheck(s)){
                Cards willDelete = CardsList.cardList.Find(card => card.Title == s);
                Console.Write($"{willDelete.Title} başlıklı kart silinecek emin misiniz (Y/N)?");
                    if(Console.ReadLine()=="Y"){
                        CardsList.cardList.Remove(willDelete);
                        Console.Write($"\n\n***************** {willDelete.Title} başlıklı kart silindi *****************\n\n");
                    }else{
                        Console.WriteLine("Kart silme iptal edildi.");
                    }
            }
            MenuYazdir();
        }
        public static void KartTasi(){
            Console.WriteLine("Güncellemek istediğiniz kartın başlığını giriniz");
            string s = Console.ReadLine();
            if(CardCheck(s)){
                Cards willChange = CardsList.cardList.Find(card => card.Title == s);
                Console.WriteLine("Bulunan kart bilgileri");
                Console.WriteLine("***********************************");
                KartYazdır(willChange);
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        willChange.Status = Status.TODO;
                        break;
                    case 2:
                        willChange.Status = Status.INPROGRESS;
                        break;
                    case 3:
                        willChange.Status = Status.DONE;
                        break;
                    default:
                        Console.WriteLine("HATALI SEÇİM");
                        MenuYazdir();
                        break;
                }
                BoardListele();
            }
            MenuYazdir();
        }
        public static void KartYazdır(Cards card){
                Console.WriteLine("Başlık       :"+card.Title);
                Console.WriteLine("İçerik       :"+card.Content);
                Console.WriteLine("Atanan Kişi  :"+card.AssignedPerson.Name);
                Console.WriteLine("Büyüklük     :"+card.Sizes);
                Console.WriteLine("-");
        }
        public static bool IsCardEmpty(Status x){
            if (CardsList.cardList.FindAll(card=> card.Status == x).Count() != 0)
                return true;
            else{
                Console.WriteLine("~ BOŞ ~");
                return false;
            }
                
        }
        public static bool CardCheck(string title,[CallerMemberName] string callerName = "")
        {
            bool isExist = false;
            if(CardsList.cardList.FindAll(card=> card.Title == title).Count() != 0){
                isExist = true;
                return true;
            }
            if(!isExist)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız."); 
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                if(Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    MenuYazdir();
                }
                else
                {
                    switch (callerName)
                    {
                        case "KartSil":
                            KartSil();
                            break;
                        /*case "KartGüncelle":
                            KartGüncelle();*/
                        default:
                            break;
                    }
                }
            }        
            return false;
        }
    }
}