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
            {
                Console.WriteLine("Hata! " + ex.Message.ToString());
            }
            finally //sonunda çalışır. Hata olsa da olmasa da çalışır.
            {
                Console.WriteLine("İşlem tamamlandı.")
            }


            try
            {
                int a = int.Parse(null);


            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş değer giriniz: ");
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


        }
    }
}
