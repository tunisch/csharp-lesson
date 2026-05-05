namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			
			byte b = 4;             // 1 byte yer kaplar bellekte
			sbyte c = 5;            // 1 byte 

			short s = 6;            //2 byte 
			ushort us = 7;          //2 byte

			Int16 i16 = 2;          //2 byte
			int i = 2;              //4 byte
			Int32 i32 = 2;          //4 byte
			Int64 i64 = 2;          //8 byte

			uint ui = 2;            //4 byte    
			long l = 4;             //8 byte
			ulong ul = 4;           //8 byte

			//Reel Sayilar
			float f = 5;            //4 byte
			double d = 5;           //8 byte
			decimal de = 5;         //16 byte

			char ch = '2';          //2 byte
			string str = "hello";   //sinirsiz byte 

			bool bl = true;         //1 byte
			bool b2 = false;        //1 byte

            DateTime dt = DateTime.Now;   //8 byte

            Console.WriteLine(dt);

            // OBJECT
            /* 
             * Türü bilinmeyen veriyi tutmak için
             * object performans olarak yavaştır(int, double, float vs gore).
            */

			object o1 = "x";			
			object o2 = 'y';
			object o3 = 4;              /* int normalde 4 byte iken, object içine koyduğunuzda bellekte en az 6-8 kat daha fazla yer kaplar. */
            object o4 = 4.3;

			//String Ifadeler

			string str1 = ""; 
			string str2 = null;			// yukardaki ve assagidaki ile ayni seydir.
			string str3 = string.Empty;

			str1 = "Tunahan";
			string ad = "Tunahan";
			string soyad = "Erturk";
			string tamIsim = ad + " " + soyad;

			// Integer tanimlama Sekilleri

			int integer1 = 5;
			int integer2 = 3;
			int integer3 = integer1 * integer2;

			// boolean

			bool bool1 = 10 > 2;

			// Degisken Donusumleri 

			string str20 = "20";
			int int20 = 20;

			string yeniDeger = str20 + int20.ToString(); //20 20 = 2020 olur
			Console.WriteLine(yeniDeger);

			int int21 = int20 + Convert.ToInt32(str20);
			Console.WriteLine(int21); // Cikti 40 olur str20 > int oldu degeride 20 olarak gecti 20 + 20 = 40 oldu.


			int int22 = int20 + int.Parse(str20); // her zaman string degerleri cevirmek icin kullaniriz
			Console.WriteLine(int22); // Cikti 40 olur.

			// Datetime

			string datetime = DateTime.Now.ToString("dd.MM.yyyy");
			Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


			// saat 

			string hour = DateTime.Now.ToString("HH:mm");
			Console.WriteLine(hour); 






















        }
    }
}
