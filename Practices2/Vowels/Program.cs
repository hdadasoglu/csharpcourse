//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
using System;
using System.Collections;

namespace Vowels{
    class Program{
        public static void Main(string[] args){
            char[] sesliharfler = {'a','e','i','ı','u','ü','o','ö'};
            string cumle = Console.ReadLine();
            char[] dizi = new char[cumle.Length];
            int count = 0;
            for(int i = 0; i< cumle.Length;i++){
                foreach (var item in sesliharfler)
                {
                    if(cumle[i]==item){
                        dizi[count] = item;
                        count++;
                    }
                }                
            }
            
            for(int i=0;i<count-1;i++){
                for(int j=0;j<count-1;j++){
                    if(dizi[j] > dizi[j+1]){
                        char a = dizi[j+1];
                        dizi[j+1] = dizi[j];
                        dizi[j] = a;
                    }
                }
            }
            // count = 0;
            Console.WriteLine(dizi);
        }
    }
}