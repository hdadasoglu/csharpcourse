using System;
namespace PhoneBook
{
    public static class Menu
    {
        public static void Yazdır(){
            Console.WriteLine("****Telefon Rehberi****");
            
            foreach (var item in MenuItems.menuler)
            {
                Console.WriteLine(item);
            }

            Console.Write("[Lütfen Seçim Yapınız] : ");
            MenuOku();
        }
        public static void MenuOku(){
            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (Check.CheckMenuItems(value))
                    MenuItems.SecimYap(value);
                else
                    Yazdır();
            }
            catch (Exception)
            {
                Check.CheckMenuItems(0);
                Yazdır();
            }
        }
    }
}