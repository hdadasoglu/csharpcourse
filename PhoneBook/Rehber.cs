using System.Collections.Generic;
using System;
namespace PhoneBook
{
    public class Rehber
    {
        public static void Ekle()
        {
            int ogeUzunluk = MenuItems.ogeler.Length;

            string[] ogeler = new string[ogeUzunluk];
            
            for(int i = 0;i<ogeUzunluk;i++)
            {
                Console.WriteLine(MenuItems.ogeler[i]);
                ogeler[i] = Console.ReadLine();
            }
            PhoneNumbersList.phoneNumbers.Add(new PhoneNumbers(ogeler[0],ogeler[1],ogeler[2]));
            Console.WriteLine("Öge Eklendi");
            Consol.Sleep(1);
            Menu.Yazdır();
        }
    }
}