using System;

namespace Interfaces2{
    class Program{
        public static void Main(string[] args){
            Focus focus = new();
            Console.WriteLine(focus.Marka().ToString());
            Console.WriteLine(focus.Renk().ToString());
            Console.WriteLine(focus.TekerSayisi());
        } 
    }
}