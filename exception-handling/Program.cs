namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + sayi);
            }
            catch (Exception ex)
            // Exception, tüm hataların temel sınıfıdır. Bu nedenle, herhangi bir türdeki hatayı yakalayabilir. Ancak, bu tür bir catch bloğu kullanırken dikkatli olunmalıdır, çünkü spesifik hataları yakalamak ve uygun şekilde ele almak genellikle daha iyidir.
            {
                Console.WriteLine("Hata! " + ex.Message.ToString());
            }
            finally //sonunda çalışır. Hata olsa da olmasa da çalışır.
            {
                Console.WriteLine("İşlem tamamlandı.");
            }


            try
            {
                int a = int.Parse(null);


            }
            catch (ArgumentNullException ex)
            // ArgumentNullException, bir yönteme veya yapıcıya null bir argüman geçirildiğinde ortaya çıkan bir hata türüdür. Bu hata, genellikle bir parametrenin null olmasının beklenmediği durumlarda meydana gelir.
            {

                Console.WriteLine("Boş değer giriniz: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);

            }
            try
            {
                Console.Write("Bir sayı gir: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girdiğin sayı: " + sayi);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hatalı giriş! Sayı girmen gerekiyordu.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(" **------------------------------** "); 
            try
            {
                Console.Write("Bir sayı gir: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girdiğin sayı: " + sayi);
            }
            catch (FormatException ex)
            // Format hatası, kullanıcıdan beklenen formatta bir veri alınamadığında ortaya çıkan bir hata türüdür. Örneğin, kullanıcıdan bir sayı girmesi beklenirken harf veya özel karakterler girdiğinde bu hata oluşur.
            {
                Console.WriteLine("Hatalı giriş! Sayı girmen gerekiyordu.");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Bölünen: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Bölen: ");
                int b = int.Parse(Console.ReadLine());

                int sonuc = a / b;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölme hatası!");
                Console.WriteLine(ex.Message);
            }

            try
            {
                string veri = null;
                int sayi = int.Parse(veri);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer parse edilemez!");
                Console.WriteLine(ex.Message);
            }

            try
            {
                string text = File.ReadAllText("olmayan_dosya.txt");
                Console.WriteLine(text);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Dosya okunamadı!");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Bir sayı gir: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                Console.Write("Sayı gir: ");
                int sayi = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format hatası! Sayı girmen gerekiyordu.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Sayı çok büyük veya çok küçük!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");
            }





            /*
             
            ➡️ Compile-time error  

            Derleme Zamanı Hataları: Kod yazarken oluşan hatalardır. Örneğin, noktalama işaretlerini yanlış kullanmak, değişken adlarını yanlış yazmak gibi hatalar derleme zamanında ortaya çıkar ve kodun derlenmesini engeller.

            ❌ 1. Değişken tipine uyumsuz bir değer atamaya çalıştığımızda
            int x = "abc";   // derleme zamanı hatası


            ❌ 2. Değişkenler arasında uyumsuz bir operatör kullandığımızda
            int x = 5;
            string y = "a";
            var z = x + y;   // derleme zamanı hatası


            ❌ 3. Komutu ; ile sonlandırmadığımızda
            int x = 5   // ; yok → derleme zamanı hatası


            ✔️ 4. int değişkeni decimal değişkene atamaya çalıştığımızda
            int a = 10;
            decimal b = a;   // HATA YOK
            
             
            ➡️ Runtime error (Execution-time error)
            
            Program çalışırken oluşan hatalardır.

            Bu aşamada yakalanan hatalar:
            
            Sıfıra bölme 
            
            Dosya bulunamaması
            
            Kullanıcıdan yanlış input gelmesi
            
            Null reference hatası
            
            API bağlantı hatası
             
            int x = 10;
            int y = 0;
            int z = x / y;   // runtime error (DivideByZeroException)
 
             
             
             
             */
        }
    }
}
