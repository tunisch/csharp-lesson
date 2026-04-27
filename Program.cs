using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicitly typed variable Conversion (Bilincsiz Tür Dönüşümü)
        byte a = 5;
        sbyte b = 30;
        short c = 10;

// a, b, c değişkenlerinin toplamını int türünde bir değişkene atayalım kapasitesi daha büyük olduğu için int turune atayabiliriz hata vermez boylelikle.
        int d = a + b + c;
        Console.WriteLine("d: " + d); 


        // Excplicitly typed variable Conversion (Bilincli Tür Dönüşümü)
    }
}
