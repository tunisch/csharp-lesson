using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicitly typeld variable Conversion (Bilincsiz Tür Dönüşümü)
        //küçükten büyüğe doğru yapılan dönüşümlerdir. Veri kaybı yaşanmaz çünkü kapasitesi daha büyük olan türler daha küçük olan türlerin değerlerini rahatlıkla alabilirler.
        Console.WriteLine("****Implicitly typeld variable Conversion (Bilincsiz Tür Dönüşümü)****");
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        // a, b, c değişkenlerinin toplamını int türünde bir değişkene atayalım kapasitesi daha büyük olduğu için int turune atayabiliriz hata vermez boylelikle.
        int d = a + b + c;
        Console.WriteLine("d: " + d); 

        long h = d; // int türünden long türüne dönüşüm yapabiliriz çünkü long'un kapasitesi int'ten daha büyüktür
        Console.WriteLine("h: " + h);

        float i = h; // long türünden float türüne dönüşüm yapabiliriz çünkü float'un kapasitesi long'dan daha büyüktür
        Console.WriteLine("i: " + i);

        string e = "Melih";
        char f = 'M';
        object g = e + f + d; // string, char ve int türlerini object türüne atayabiliriz çünkü object tüm türlerin üstünde bir türdür kapsaite bakimindan buyuk oldugu icin hata vermez ve tercih edilir.
        Console.WriteLine("g: " + g);

        
        // Excplicitly typed variable Conversion (Bilincli Tür Dönüşümü) Parse ve Convert sınıfları ile yapılan dönüşümlerdir. Dönüşüm yaparken veri kaybı yaşanabilir bu yüzden bilinçli olarak yapılır.
        //  Büyük tip → küçük tipe dönüşüm yaparken veri kaybı yaşanabilir çünkü büyük tiplerin kapasitesi küçük tiplerin kapasitesinden daha büyüktür bu yüzden bilinçli olarak yapılır.
        Console.WriteLine("****Explicitly typed variable Conversion (Bilincli Tür Dönüşümü)****");

        int x = 4;
        byte y = (byte)x; // int türünden byte türüne dönüşüm yaparken
    
        Console.WriteLine("y: " + y);
    

        int z = 100;
        byte t = (byte)z; // int türünden byte türüne dönüşüm yaparken veri kaybı yaşanabilir çünkü byte'un kapasitesi int'ten daha küçüktür bu yüzden 100 sayısı byte'un kapasitesini aştığı için veri kaybı yaşanır ve sonuç 44 olur.
        
        Console.WriteLine("t: " + t);
    
        int w = 100;
        byte v = Convert.ToByte(w); // int türünden byte türüne dönüşüm yaparken Convert sınıfını kullanarak dönüşüm yapabiliriz ancak veri kaybı yaşanabilir çünkü byte'un kapasitesi int'ten daha küçüktür bu yüzden 100 sayısı byte'un kapasitesini aştığı için veri kaybı yaşanır ve sonuç 44 olur.
        
        Console.WriteLine("v: " + v);
    
        float s = 10.3f;
        byte r = (byte)s; // float türünden byte türüne dönüşüm yaparken
        Console.WriteLine("r: " + r);

        // ToString Methodu 
        // ToString() methodu herhangi bir veri türündeki değeri string türüne dönüştürmek için kullanılır. Tüm veri türleri ToString() methodunu kullanarak string türüne dönüştürülebilirler.
        Console.WriteLine("****ToString Methodu****");
        int xx = 6;
        string yy = xx.ToString(); // int türünden string türüne dönüşüm yaparken ToString() methodunu kullanarak dönüşüm yapabiliriz.
        Console.WriteLine("yy: " + yy);

        string zz = 12.5f.ToString(); // float türünden string türüne dönüşüm yaparken ToString() methodunu kullanarak dönüşüm yapabiliriz.
        Console.WriteLine("zz: " + zz);

        // System.Convert sınıfı
        Console.WriteLine("****System.Convert sınıfı****"); 
        string s1 = "10", s2 = "20"; // tek satırda bırden fazla değişken tanımlayabiliriz ve değer atayabiliriz.
        int sayi1, sayi2;
        int Toplam;
        sayi1 = Convert.ToInt32(s1); // string türünden int türüne dönüşüm yaparken Convert sınıfını kullanarak dönüşüm yapabiliriz.
        sayi2 = Convert.ToInt32(s2); // string türünden int türüne
        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + Toplam);


        // Parse Methodu
        // String türünden diğer türlere dönüşüm yaparken Parse() methodunu kullanarak dönüşüm yapabiliriz ancak veri kaybı yaşanabilir çünkü string türündeki verinin içeriği dönüştürülmek istenen türün kapasitesini aşabilir bu yüzden bilinçli olarak yapılır.
        Console.WriteLine("****Parse Methodu****");
        ParseMethod();

    }

    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1); // string türünden int türüne dönüşüm yaparken Parse() methodunu kullanarak dönüşüm yapabiliriz.
        Console.WriteLine("rakam1: " + rakam1);

        double1 = Double.Parse(metin2); // string türünden double türüne dönüşüm yaparken Parse() methodunu kullanarak dönüşüm yapabiliriz.
        Console.WriteLine("double1: " + double1);

        //BOXING VE UNBOXING
        // Boxing: Değer tipindeki bir değişkenin referans tipine dönüştürülmesidir. Değer tipi, stack'te saklanırken referans tipi heap'te saklanır. Boxing işlemi sırasında değer tipi, heap'e kopyalanır ve referans tipi olarak kullanılır.
        // Unboxing: Referans tipindeki bir değişkenin değer tipine dönüştürülmesidir. Unboxing işlemi sırasında referans tipi, stack'e kopyalanır ve değer tipi olarak kullanılır.
        Console.WriteLine("****Boxing ve Unboxing****");

        int a = 123; // Değer tipi
        object obj = a; // Boxing işlemi
        Console.WriteLine("obj: " + obj); 

        Console.WriteLine("****Unboxing****");
        object obj2 = 10; // Boxing işlemi
        int b = (int)obj2; // Unboxing işlemi
        Console.WriteLine("b: " + b);





    }
}
