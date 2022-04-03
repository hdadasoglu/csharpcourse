using System;

namespace if_else
{
    public class Program
    {
        static void Main(string[] args){
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın");
            else if (time > 11)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi geceler");
        
            Console.WriteLine(time>=6 && time<11? "Günaydın" : time>11 ? "İyi günler":"İyi geceler");
        }
        
    }
}