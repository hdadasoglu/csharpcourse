using System;

namespace RecursiveFunctions{
    public class Program{
        public static void Main(string[] args){
            // not recursive
            // 3*3*3*3
            int result = 1;

            for (int i = 0; i < 4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,5));


            // Extension Methodlar

            string ifade = "Hüseyin Dadaşoğlu";
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(ifade.RemoveSpaces());
            Console.WriteLine(ifade.UpperCase());
            Console.WriteLine(ifade.LowerCase());
            int[] dizi = {3,7,6,2,9};
            int[] dizi1 = dizi.IntSort();
            dizi1.EkranaYaz();
        }
    }
}

public class Islemler{
    public int Expo (int sayi, int exp){
        return exp<2 ? sayi: Expo(sayi,exp-1)*sayi ;
    }
    // Expo(3,4)
    // Expo(3,3) * 3
    // Expo(3,2) * 3 * 3
    // Expo(3,1) * 3 * 3 * 3
    // return 3 * 3 * 3 * 3
}

public static class Extension{
    public static bool CheckSpaces(this string param){
        return param.Contains(" ");
    }
    public static string RemoveSpaces(this string param){
        string [] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
    public static string UpperCase(this string param){
        return param.ToUpper();
    }
    public static string LowerCase(this string param){
        return param.ToLower();
    }
    public static int[] IntSort(this int[] param){
        int a;
        for (int j = 0; j < param.Length; j++)
        {    
            for (int i = 0; i < param.Length-1; i++)
            {
                if(param[i]>param[i+1]){
                    a = param[i+1];
                    param[i+1] = param[i];
                    param[i] = a;     
                } 
            }
        }    
        return param;
    }
    public static void EkranaYaz (this int[] param){
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }    
    }
    public static bool IsEven(int param){
        return param%2==0;
    }
}