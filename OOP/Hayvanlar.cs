namespace OOP
{
    public class Hayvanlar:Canlılar
    {
        public void Adaptasyon(){
            Console.WriteLine("Adaptasyon Yeteneği");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar kaçar");
        }
    }
    public class Sürüngenler:Hayvanlar{
        public Sürüngenler(){
            base.Solunum();
            base.Bosaltım();
            base.Beslenme();
        }
        public void SürünerekHareketEtmek(){
            Console.WriteLine("Sürünerek hareket eder");
        }
    }
    public class Kuslar:Hayvanlar{
        public Kuslar(){
            base.Solunum();
            base.Bosaltım();
            base.Beslenme();
            base.UyaranlaraTepki();
        }
        public void Uçmak(){
            Console.WriteLine("Uçar");
        }
    }
}