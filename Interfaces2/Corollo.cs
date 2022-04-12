namespace Interfaces2
{
    public class Corolla : IOtomobil
    {
        public Markalar Marka()
        {
            return Markalar.Toyota;
        }

        public Renkler Renk()
        {
            return Renkler.Beyaz;
        }

        public int TekerSayisi()
        {
            return 4;   
        }
    }
}