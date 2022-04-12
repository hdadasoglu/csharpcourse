namespace OOP
{
    public class Bitkiler:Hayvanlar
    {
        protected void Fotosentez(){
            Console.WriteLine("Fotosentez Yapar");
        }
    }

    // Bitkiler sınıfının fotosentez özelliğini dışarıya kapatıp sadece miras alınan sınıflarda kullanmak istediğim için protected yaptım kalıtım kullanılmadan protected method çağırılamaz. Protected methodu miras bıraktığımız class içerisinde çağırabilmek constructor içinde base fonksiyonunu kullanmamız gerekiyor

    public class TohumluBitkiler : Bitkiler{
        
        
        // Constructor
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Bosaltım();
            base.Beslenme();
        }
        public void TohumlaÇoğalma(){
            Console.WriteLine("Tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler{

        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Solunum();
            base.Bosaltım();
            base.Beslenme();
        }
        public void SporlaÇoğalma(){
            Console.WriteLine("Sporla çoğalır");
        }
    }

}