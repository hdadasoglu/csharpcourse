namespace Abstract
{
    public abstract class Arabalar
    {
        public int TekerSayisi(){
            return 4;
        }
        public abstract Markalar Marka();

        public virtual Renkler Renk(){
            return Renkler.Beyaz;
        }
    }
}