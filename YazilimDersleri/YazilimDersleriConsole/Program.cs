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
/*
 * C# programlama dili diğer programlama dillerinde olduğu iki türlü koşul
 * kodu bulunmaktadır bunlardan if else switch case
 * switch case çoktan seçmeli koşullarda if else'ten daha hızlı çalışır.
 * 
 */
/*
double sayi1, sayi2, toplam;
int secim = 0;
Console.WriteLine("Lütfen seçiminizi yapınız.");
Console.WriteLine("1- Toplama\n2- Çıkarma\n3- Çarpma \n4- Bölme");
secim = int.Parse(Console.ReadLine());
if (secim == 1)
{
    Console.WriteLine("1. Sayıyı Giriniz : ");
    sayi1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz : ");
    sayi2 = Convert.ToDouble(Console.ReadLine());
    toplam = sayi1 + sayi2;
    Console.WriteLine("Sayıların Toplamı : " + toplam);
}
else if (secim == 2)
{
    Console.WriteLine("1. Sayıyı Giriniz : ");
    sayi1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz : ");
    sayi2 = Convert.ToDouble(Console.ReadLine());
    toplam = sayi1 - sayi2;
    Console.WriteLine("Sayıların Farkı : " + toplam);
}
else if (secim == 3)
{
    Console.WriteLine("1. Sayıyı Giriniz : ");
    sayi1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz : ");
    sayi2 = Convert.ToDouble(Console.ReadLine());
    toplam = sayi1 * sayi2;
    Console.WriteLine("Sayıların Çarpım : " + toplam);
}
else if (secim == 4)
{
    Console.WriteLine("1. Sayıyı Giriniz : ");
    sayi1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz : ");
    sayi2 = Convert.ToDouble(Console.ReadLine());
    toplam = sayi1 / sayi2;
    Console.WriteLine("Sayıların Bölümünün Sonucu : " + toplam);
}
else
{
    Console.WriteLine("Yanlış yaptın");
}
switch (secim)
{
    case 1:
        Console.WriteLine("1. Sayıyı Giriniz : ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Giriniz : ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        toplam = sayi1 + sayi2;
        Console.WriteLine("Sayıların Toplamı : " + toplam);
        break;
    case 2:
        Console.WriteLine("1. Sayıyı Giriniz : ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Giriniz : ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        toplam = sayi1 - sayi2;
        Console.WriteLine("Sayıların Farkı : " + toplam);
        break;
    case 3:
        Console.WriteLine("1. Sayıyı Giriniz : ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Giriniz : ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        toplam = sayi1 * sayi2;
        Console.WriteLine("Sayıların Çarpım : " + toplam);
        break;
    case 4:
        Console.WriteLine("1. Sayıyı Giriniz : ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Giriniz : ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        toplam = sayi1 / sayi2;
        Console.WriteLine("Sayıların Bölümünün Sonucu : " + toplam);
        break;
    default:
        Console.WriteLine("Yanlış yaptın");
        break;
}
*/
/*
double r1, r2, r3, rt;
Console.WriteLine("1. Direnç Değerini Giriniz : ");
r1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2. Direnç Değerini Giriniz : ");
r2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("3. Direnç Değerini Giriniz : ");
r3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("1- Seri\n2- Parelel");
int secim = Convert.ToInt32(Console.ReadLine());
switch (secim)
{
    case 1:
        rt = r1 + r2 + r3;
        Console.WriteLine("Seri Devrenin Değeri : " + rt);
        break;
    case 2:
        rt = 1 / ((1 / r1) + (1 / r2) + (1 / r3));
        Console.WriteLine("Parelel Devrenin Değeri : "+rt);
        break;
    default:
        Console.WriteLine("%50 %50 şıkkın var onu bile beceremiyon");
        break;
}
*/
/*Console.WriteLine("Bir Sayı Giriniz : ");
double sayi = Convert.ToDouble(Console.ReadLine());
if (sayi < 0)
{
    Console.WriteLine("Sayı Negatif");
}
else if (sayi > 0)
{
    Console.WriteLine("Sayı Pozitif");
}
else
{
    Console.WriteLine("Sayı Nötr'dür");
}
if (sayi < 0)
    Console.WriteLine("Sayı Negatiftir.");
else if (sayi > 0)
    Console.WriteLine("Sayı Pozitif");
else Console.WriteLine("Sayı Nötr");
*/
/*
 * For Döngüsü (Koşul önde gelip döngünün devamlılığını önden verip yapıyor işlemi)
 * for(int i=0; i<10; i++)
 * {
 *      Console.WriteLine(i);
 * }
 
 */
/*for (int i = 0; i <= 3; i++)
{
    Console.WriteLine(i);
}*/
/*int a = 0;*/
/*while (a <= 3)
{
    Console.WriteLine(a);
    a++;
}*/
/*
do
{
    Console.WriteLine(a);
    a++;
} while (a<=3);
*/
/*Kullanıcıdan 10 adet sayı istiyoruz bunların 50'den küçük alanlarının
 sayını bulan program*/
/*int sayi, sayac = 0, i=1;*/
/*for (int i = 1; i <= 10; )
{
    Console.WriteLine("{0}. Sayıyı Giriniz : ", i);
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi <= 50)
        sayac++;
}*/
/*while (i<=10)
{
    Console.WriteLine("{0}. Sayıyı Giriniz : ", i);
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi <= 50)
        sayac++;
    i++;
}*/
/*do
{
    Console.WriteLine("{0}. Sayıyı Giriniz : ", i);
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi <= 50)
        sayac++;
    i++;
} while (i<=10);*/
/*
Console.WriteLine
    ("50'ye eşit ve 50'den küçük olan sayı adedi : " + sayac);*/
/*
 * Kullanıcıdan Başlangıç, bitiş ve artış değerini isteyerek
 * verilen artış miktarına göre Başlangıç Bitiş Sayıları arasında
 * döngü oluşturan program.
 */
/*int baslangic, bitis, artis,a;
Console.WriteLine("Başlangıç Sayısı : ");
baslangic = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitiş Sayısı : ");
bitis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Artış Sayısı : ");
artis = Convert.ToInt32(Console.ReadLine());
for (int i = baslangic; i <= bitis; i+=artis)
{
    Console.WriteLine(i);
}
while (baslangic<=bitis)
{
    a = baslangic;
    Console.WriteLine(a);
    a += artis;
}
do
{
    a = baslangic;
    Console.WriteLine(a);
    a += artis;
} while (baslangic <= bitis);*/
/*
 * Soru 1 = Kullanıcdan Girilen Sayının Tek mi? Çift mi olduğunu bulan
 * program.
 * Soru 2 = Girilen 2 Sayıdan Büyük Olanını Bulan Program.
 * Soru 3 = Haklı Sayı Bulma Oyunu
 * Soru 4 = Atm'den Para Çekme Uygulaması. Kullanıcı Para Çekme
 * İşlemini bitirene kadar atmden para çekebilsin.
 * Soru 5 = Girilen 2 Sayının Hangisinin kendisine Tam Bölünen
 * Sayı olduğunu bulan program.
 */
int sayi = 56;
if (sayi % 2 == 0)
    Console.WriteLine("Sayı Çift");
else Console.WriteLine("Sayı Tek");
int say1 = 25, say2 = 35;
if (sayi > say2)
{
    Console.WriteLine("Sayı 1 Sayı 2 den büyüktür");
}
else if (say2 > say1)
{
    Console.WriteLine("Sayı 2 Sayı 1 den büyüktür");
}
else
{
    Console.WriteLine("Sayı Birbirine eşittir.");
}
int sayi1=22, sayi2=25;
if (sayi1 / sayi1 == 1 && sayi2 / sayi2 == 1)
{
    Console.WriteLine("Sayı kendisine bölünüyor");
}
else
{
    Console.WriteLine("Sayı kendisine bölünmüyor");
}
Console.ReadKey();