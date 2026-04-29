using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicitly typeld variable Conversion (Bilincsiz Tür Dönüşümü)
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
    
        int x = 4;
        byte y = (byte)x; // int türünden byte türüne dönüşüm yaparken
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
