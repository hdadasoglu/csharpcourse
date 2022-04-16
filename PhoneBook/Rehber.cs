using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

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
            Menu.Yazdır();
        }
        public static void KayıtSil(){
            Console.Write("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz : ");
            PhoneNumbers phoneNumber = AramaYap(Console.ReadLine());
            
            if(phoneNumber != null){
                Console.Write("{{{0}}} silinecek emin misiniz ? (Y/N) ",phoneNumber.Isim);
                    string s = Console.ReadLine();;
                    if(s == "y" || s == "N"){
                        PhoneNumbersList.phoneNumbers.Remove(phoneNumber);
                        Console.WriteLine("Kayıt Silindi");
                        Menu.Yazdır();
                    }
            }

            else{
                KayıtYok();
            }

        }

        public static void KayıtGüncelle(){

            Console.Write("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz : ");
            PhoneNumbers phoneNumber = AramaYap(Console.ReadLine());
            
            if(phoneNumber != null)
            {
                Console.Write("{{{0}}} güncellenecek emin misiniz ? (Y/N) ",phoneNumber.Isim);
                string s = Console.ReadLine();;
                if(s == "y" || s == "N")
                {
                        
                    int ogeUzunluk = MenuItems.ogeler.Length;

                    string[] ogeler = new string[ogeUzunluk];
            
                    for(int i = 0;i<ogeUzunluk;i++)
                    {
                        Console.Write(MenuItems.ogeler[i]);
                        ogeler[i] = Console.ReadLine();
                    }
                        
                    phoneNumber.Isim = ogeler[0];
                    phoneNumber.SoyIsim = ogeler[1];
                    phoneNumber.Numara = ogeler[2];
                    KayıtYazdır(phoneNumber);
                    Menu.Yazdır();
                }
            }
            else
            {
                KayıtYok();
            }

        }
        public static void Listele(){
            foreach (var item in PhoneNumbersList.phoneNumbers)
            {
                KayıtYazdır(item);
            }
            Menu.Yazdır();
        }
        public static void KayıtBul(){
            Console.Write("Lütfen aradığınız kayıtın ismini veya soy ismini giriniz : ");
            PhoneNumbers kayıt = AramaYap(Console.ReadLine());
            
            if (kayıt != null)
            {
                Console.WriteLine("Kayıt Bulundu.");
                KayıtYazdır(kayıt);
                Menu.Yazdır();
            }
            else{
                KayıtYok();
            }
        }
        public static PhoneNumbers AramaYap(string s){
            bool isExist = false;
            foreach (var item in PhoneNumbersList.phoneNumbers)
            {
                if (item.Isim == s || item.SoyIsim == s){
                    isExist = true;
                    if(isExist){
                        return item;
                    }
                }
            }
            return null;
        }
        public static void KayıtYazdır(PhoneNumbers phoneNumbers){
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim         :   {{{0}}}",phoneNumbers.Isim);
            Console.WriteLine("Soyisim      :   {{{0}}}",phoneNumbers.SoyIsim);
            Console.WriteLine("Numara       :   {{{0}}}",phoneNumbers.Numara);
            Console.WriteLine("****************************************");
        }
        
        // Kayıt Yok methodunu çağıran methodun ismini aldık bu şekilde o methoda tekrar dönüş yaptırabildik.
        public static void KayıtYok([CallerMemberName] string callerName=""){
            Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı.\nLütfen bir seçim yapınız(Tekrar denemek için 1, Çıkmak için herhangi bir tuş) : ");
                if(Console.ReadLine() == "1"){
                    switch (callerName)
                    {
                        case "KayıtBul":
                            KayıtBul();
                            break;
                        case "KayıtSil":
                            KayıtSil();
                            break;
                        default:
                            Console.WriteLine("Hata CallerMembername");
                            break;
                    }
                }else{
                    Menu.Yazdır();
                }
        }
    }
}