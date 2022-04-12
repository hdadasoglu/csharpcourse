namespace Interfaces2
{
    public class Focus : IOtomobil
    {
        public Markalar Marka()
        {
            return Markalar.Ford;
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