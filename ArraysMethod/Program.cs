using System;

namespace ArraysMethod
{
    public class Program
    {
        static void Main(string[] args){
            
            // Array
            int[] sayilar = {23,12,52,345,21,2,9};

            Console.WriteLine("## Sırasız Dizi ##");
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");    
            }
            // Sort
            Console.WriteLine("\n## Sıralı Dizi ##");
            Array.Sort(sayilar);
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");    
            } 
            // Clear 
            Console.WriteLine("\n## Array Clear ##");
            Array.Clear(sayilar,0,2); // arr index lenght
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");    
            }
            // Reverse
            Console.WriteLine("\n## Reverse ##");
            Array.Reverse(sayilar);
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");    
            }
            // Index of
            Console.WriteLine("\n## İndex Of ##");
            Console.Write(Array.IndexOf(sayilar,21)); // arr obj
            // Resize
            Console.WriteLine("\n## Resize ##");
            Array.Resize(ref sayilar,99);
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");    
            }

        }
    }
}


