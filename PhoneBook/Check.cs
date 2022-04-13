namespace PhoneBook
{
    public static class Check
    {
        public static bool CheckNull(string? s){
            if(s != null)
                return true;
            else
                Console.WriteLine("Lütfen alanı boş bırakmayınız");
                return false;
        }
        public static bool CheckMenuItems(int i){
            if(i<1 || i>MenuItems.menuler.Length){
                Console.WriteLine("Hatalı giriş");
                Consol.Sleep(2);
                return false;
            }else
                return true;
        }
    }
}