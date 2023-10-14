// See https://aka.ms/new-console-template for more information

/*
 * Programlamada bilgisayara birşeyleri tanıtmak için değişkenleri kullanırız
 * her değişkenin birer tipleri vardır. Bu değişken tipleri programlama yaparken
 * ihtiyaca binayen kullanılır.
 * byte = Uzunluğu 1 Byte'tır ve 0 ile 255 tam sayıları arasında değer almaktadır.
 * sybyte Uuzuluğu 1 Bytre'tır. ve -128 ile 127 arasında değer alır.
 * short Uzunluğu 2 Byte'tır ve -32768 ile 32767 arasında değer alıyor.
 * ushort Uzunluğu 2 Byte'tır ve 0 ile 65535 arasında değer alır.
 * int Uzunluğu 4 Byte'tır -2.147.483.648 sayısı ile 2.147.483.648 arasında değer alır.
 * uint Uzunluğu 4 Byte'tır 0 ile 4.229.967.295 arasında değer alır
 * long uzunluğu 8 Byte'tır -10^20 ile 10^20 arasında değer alır
 * ulong uzunluğu 8 Byte'tır  0 ile 10^20 arasında değer alır.
 * float = uzunluğu 4 Byte'tır 1.5x10-45 ile 3.4 x10^38 arasında değer alır.
 * double = Uuzuluğu 8 Byte'tır 5.0x10-324 ile 1.7 x10^308 arasında değer alır
 * decimal = Uzunluğu 12Byte'tır
 * char = Uzunluğu 2 Byte'tır Sadece Tek bir karekter alır 2 A
 * string =metin yazmak kullanılır.
 * boolean=True False arasında değer alır.
 */
//int a, b;
//a = 5; b = 6;
// Ekrana Çıktı vermek ve ekrandan değer almak için kullanılır.
//Console.WriteLine((a + b));
// Ekran kapanmamasını istiyorsak bu kodu kullanırız.
/*Bir ürünün KDV'sini bulan programı yazınız.*/
/*int urun=100, kdv = 20;
urun = urun * kdv / 100 + urun;
Console.WriteLine("Ürünün Fiyatı : "+ urun);*/
// Default yani varsayılan değerlerle işlem yapıyoruz.
// değişekene varsayılan değer atarak işlemler yaptım

//Kullanıcıdan sayı alarak işlem yapacağız.

/*int say1, say2;
Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
say1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
say2= Convert.ToInt32(Console.ReadLine());
say1 = say1+ say2;
Console.WriteLine("İki Sayının Toplamı : " + say1);*/

/*
 * Dikdörtgenin Alan Formülü = alan = kisaKenar*uzunKenar;
 * Dikdörtgenin Çevre Formülü = cevre=2*(kisaKenar+uzunKenar);
 */

/*int kisa, uzun, alan, cevre;
Console.WriteLine("Kısa Kenarı Giriniz : ");
kisa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Uzun Kenarı Giriniz : ");
uzun = Convert.ToInt32(Console.ReadLine());

alan = kisa * uzun;
cevre = 2 * (kisa + uzun);
Console.WriteLine("Alan Hesap Sonucu : " + alan);
Console.WriteLine("Çevre Hesap Sonuu : " + cevre);*/
/*Yarı çapı girilen dairenin alanını ve çevresini bulan program*/
double yaricap, alan, cevre;
/*
 * Alan = 3.14 * yaricap * yaricap;
 * Cevre  2* 3.14 * yaricap;
 */
/*Console.WriteLine("Yarı Çapı Giriniz : ");
yaricap = Convert.ToDouble(Console.ReadLine());
alan = 3.14 * yaricap * yaricap;
cevre = 2 * 3.14 * yaricap;
Console.WriteLine("Alan : " + Math.Round(alan,2));
Console.WriteLine("Çevre : " +  Math.Round(cevre,2));
*/

/*3 Yazılı notu girilen öğrencinin ortalamasını gösteren programı yazınız.
 * Alış Fiyatı Girilen malın kullanıcının girdiği yüzdelik karla satış fiyatını bulan C# Console Örneği.
 * Girilen Sayının Karesini ve Kübünü Alan Programı yazınız.
 * 
 */
Console.ReadKey();