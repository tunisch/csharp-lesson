using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdirma Komutlari

            //Console.Write("Hello World!"); // yazar "yan satira" gecer imlec
            //Console.WriteLine("Selam"); // yazar ve "alt satira" gecer imlec


            #endregion

            #region Degiskenler ve Veri Tipleri

            //string: metinsel ifadeleri tutar

            //string name = "Ahmet";

            //name =" Tuna ";

            //Console.Write(name);

            #endregion

            #region Mantiksal Operatorler


            //string capital, country;
            //Console.Write("Başkentı Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.Write("Doğru Bilgi");
            //}
            //else
            //{
            //    Console.Write("Yanlış Bilgi");
            //}

            #endregion

            #region if-else if

            //int exxam1, exxam2, exxam3, average;
            //var result = "hata!";

            //Console.Write("Sınavı1: ");
            //exxam1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Sınavı2: ");
            //exxam2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Sınavı3: ");
            //exxam3 = Convert.ToInt32(Console.ReadLine());

            //average = (exxam1 + exxam2 + exxam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average >= 0 && average <= 50) result = "Başarısız";
            //else if (average > 50 && average <= 70) result = "Orta";
            //else if (average > 70 && average <= 85) result = "İyi";
            //else if (average > 85 && average <= 100) result = "Pekiyi";

            //Console.WriteLine(result); // if-else if girmedigi durumlarda "hata!" yazacak 


            #endregion

            #region Switch-Case

            //Console.WriteLine("Lütfen Ay girişi yapınız: ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;

            //    default: // Hiçbir durum sağlanmazsa çalışır
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //        break;
            //}


            #endregion

            #region Switch-Case Hesap Makinesi

            //int number1, number, result;
            //char symbol;

            //Console.Write("1. Sayı: ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. Sayı: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen İşlem Seçiniz (+, -, *, /): ");
            //symbol = Convert.ToChar(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number;
            //        Console.Write("Sonuç: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number;
            //        Console.Write("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number;
            //        Console.Write("Sonuç: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number;
            //        Console.Write("Sonuç: " + result);
            //        break;
            //    default:
            //        Console.Write("Hatalı işlem!");
            //        break;
            //}

            #endregion

            #region while Dongusu

            //while(şart)
            // {
            // işlemler
            //}


            #endregion

            #region Diziler and try-catch exception handling

            //DeğişkenTürü[] diziAdı = new DeğişkenTürü[diziElemanSayısı];

            //string[] colours = new string[4];
            //int index = 4;

            //colours[0] = "Red";
            //colours[1] = "Green";
            //colours[2] = "Blue";
            //colours[3] = "Yellow";


            //Console.WriteLine(colours[0]);


            //Console.WriteLine(colours[1]);
            //Console.WriteLine(colours[2]);
            //Console.WriteLine(colours[3]);



            //try
            //{

            //    Console.WriteLine(colours[index]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata!" + ex.Message);
            //}



            //int[] myArray = {46,45,45,32,12,324,122,321,123};


            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}


            //Console.WriteLine("En büyük sayı: " + maxNumber);

            #endregion

            #region Arrays and debugger 

            //int[] numbers = { 46, 45, 45, 47, 12, 324, 345 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Arrays and methods

            //int[] numbers = {45,85,96,63,74,10,23,56,78,90};

            //Console.WriteLine("Dizinin En bÜYÜK eLEMANI: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion



            Console.Read();

        }
    }
}
