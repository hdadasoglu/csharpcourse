using System;

namespace PhoneBook
{
    class Program{
        public static void Main(string[] args){
            // 5 Adet Kayıt eklendi
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers("Dilber","Adlığ","545"));
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers("Hüseyin","Dadaşoğlu","542"));
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers("Ahmet","Aslan","543"));
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers("Ayşe","Aşra","555"));
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers("Hamiyet","Yılmaz","566"));
            // Menu Yazdırıldı
            Menu.Yazdır();
        }
    }
}