namespace Interfaces2
{
    public class Civic : IOtomobil
    {
        public Markalar Marka()
        {
            return Markalar.Honda;
        }

        public Renkler Renk()
        {
            return Renkler.Gri;
        }

        public int TekerSayisi()
        {
            return 4;   
        }
    }
}