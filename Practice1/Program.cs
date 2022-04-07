Console.WriteLine("**** C# 101 Algoritma Soruları ****");

Practices practises = new();

//Soru 1 : Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
practises.EvenNumbers();


//Soru 2 : Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
practises.Dividers();

//Soru 3 :  Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
practises.ReverseStringArray();


//Soru 4 : Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
practises.CountCharacter();


class Practices{

    public void EvenNumbers()
    {
        Console.WriteLine("\n**** Soru 1 : Kullanıcıdan n tane sayı alın çift olanları ekrana yazdırın****");

        Console.Write("\nKaç adet sayı girişi olacak :");  
        int n = Convert.ToInt32(Console.ReadLine()); 

        int[] dizi = new int[n]; // n elemanlı bir int dizi oluşturuluyor
        ReadArray(dizi); // dizi consoldan okunuyor

        Console.Write("\nÇift olan sayılar : ");
        foreach (var item in dizi)
        {
            if (item%2==0) // çift olan sayılar yazdırılıyor
                Console.Write(item+" ");
        }
    }


    public void Dividers()
    {
        Console.WriteLine("\n**** Soru 2 : Girilen sayılardan tam bölenleri bulunuz ****");

        Console.Write("\nHangi sayının bölenleri kontrol edilecek : ");
        int m = Convert.ToInt32(Console.ReadLine());  // Bölünecek sayı

        Console.Write("\nKaç adet sayı girişi olacak :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] dizi = new int[n]; // n elemanlı bir int dizi oluşturuluyor
        ReadArray( dizi); // dizi consoldan okunuyor

        Console.Write("\n{0} sayısının girilen sayılar arasından tam bölenleri : ",m);
        foreach (var item in dizi)
        {
            if(m%item==0)
                Console.Write(item+" ");
        }
    }
    
    public void ReverseStringArray()
    {
        Console.WriteLine("\n**** Soru 3 : Girilen string arrayı ters çeviriniz ****");

        Console.Write("\nKaç adet String girilecek ");
        int n = Convert.ToInt32(Console.ReadLine()); 

        string[] dizi = new string[n]; // n elemanlı bir int dizi oluşturuluyor  
        ReadArray( dizi);// dizi consoldan okunuyor

        Array.Reverse(dizi); // dizi ters çevriliyor

        foreach (var item in dizi)
        {
            Console.Write(item+" ");
        }
    }
    
    public void CountCharacter()
    {
        Console.WriteLine("\n**** Soru 3 : Girilen cümlenin harf sayısını yazdırınız ****");
        string cumle = Console.ReadLine(); // Kullanıcıdan cümle alınıyor
        cumle = cumle.Replace(" ",String.Empty); // Boşluklar siliniyor
        Console.WriteLine("Girdiğiniz cümle {0} harflidir.",cumle.Length);
    }

    
    // dizinin consoldan alınabilmesi için overload bir method tanımı
    public void ReadArray(int[] array)
    {

        for (int i = 0; i< array.Length;i++)
        {
            Console.Write("\nLütfen {0}. sayıyı giriniz : ",i+1); // sayılar sırasıyla alınıyor
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
    }
    public void ReadArray(string[] array)
    {
        for (int i = 0; i< array.Length;i++)
        {
            Console.Write("\nLütfen {0}. kelimeyi giriniz : ",i+1); // sayılar sırasıyla alınıyor
            array[i] = Console.ReadLine();
        }
    }
}
