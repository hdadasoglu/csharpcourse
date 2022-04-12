namespace OOP
{
    public class Canlılar
    {
        protected void Beslenme(){
            Console.WriteLine("Beslenir");
        }
        protected void Solunum(){
            Console.WriteLine("Solunum Yapar");
        }
        protected void Bosaltım(){
            Console.WriteLine("Boşaltım Yapar");
        }
        
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
        
    }
}