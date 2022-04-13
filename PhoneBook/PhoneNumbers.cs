namespace PhoneBook
{
    public class PhoneNumbers
    {
        private string? _isim;
        private string? _soyİsim;
        private string? _numara;

        public string? Isim 
        { 
            get => _isim; 
            set
            {
                if(Check.CheckNull(value))
                    _isim = value;
            }
        }
        public string? SoyIsim 
        {  
            get => _soyİsim; 
            set
            {
                if(Check.CheckNull(value))
                    _soyİsim = value;
            }
        }
        public string? Numara 
        {
            get => _numara; 
            set
            {
                if(Check.CheckNull(value))
                    _numara = value;
            }
        }

        public PhoneNumbers(string isim,string soyisim,string numara){
            Isim = isim;
            SoyIsim = soyisim;
            Numara = numara;
        }
    }
}