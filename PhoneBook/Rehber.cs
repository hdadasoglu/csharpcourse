using System.Collections.Generic;
using System;

#nullable disable

namespace PhoneBook
{
    public class Rehber
    {
        public static void KayıtEkle()
        {
            int ogeUzunluk = MenuItems.ogeler.Length;

            string[] ogeler = new string[ogeUzunluk];
            
            for(int i = 0;i<ogeUzunluk;i++)
            {
                Console.Write(MenuItems.ogeler[i]);
                ogeler[i] = Console.ReadLine();
            }
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers(ogeler[0],ogeler[1],ogeler[2]));
            KayıtYazdır(PhoneNumbersList.phoneNumbers.Last());
            Consol.Sleep(1);
            Menu.Yazdır();
        }
        public static void KayıtSil(string s){
            foreach (var item in PhoneNumbersList.phoneNumbers)
            {
                
            }
        }
        public static void AramaYap(string s){
            
            foreach (var item in PhoneNumbersList.phoneNumbers)
            {
                if (item.Isim == s || item.SoyIsim == s)
                    Console.WriteLine("Kayıt Bulundu");
                    KayıtYazdır(item);
            }

        }
        public static void KayıtYazdır(PhoneNumbers phoneNumbers){
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim         :   {{{0}}}",phoneNumbers.Isim);
            Console.WriteLine("Soyisim      :   {{{0}}}",phoneNumbers.SoyIsim);
            Console.WriteLine("Numara       :   {{{0}}}",phoneNumbers.Numara);
            Console.WriteLine("-");
        }
    }
}