// See https://aka.ms/new-console-template for more information
using DerslerDevamEdiyor.Arayuz;
using DerslerDevamEdiyor.Kalitim;

/*Önce Çalışan Alt Klası için bir tanımlama yapacağız.*/
/*
Personel personel = new Personel();
personel.CalisanNo = 1;
personel.CalisanAd = "Haşmet Tazegül";
personel.CalisanMaas = 11402.32;
personel.SatisSayisi = 15000;

Console.WriteLine("Personel Numarası : {0}\nPersonel Maaşı : {1}\nPersonel Adı Soyadı : {2}\nPersonel Satış Sayıyı : {3}", personel.CalisanNo, personel.CalisanMaas, personel.CalisanAd, personel.SatisSayisi);
Yonetici yonetici = new Yonetici();
yonetici.CalisanNo = 1;
yonetici.CalisanMaas = 136780.52;
yonetici.CalisanAd = "Mahmut Tuncer";
yonetici.DepertmanKar = 175000;
Console.WriteLine("Yönetici Numarası : {0}", yonetici.CalisanNo);
Console.WriteLine("Yönetici Adı Soyadı :{0} ", yonetici.CalisanAd);
Console.WriteLine("Yönetici Maaşı : {0}", yonetici.CalisanMaas);
*/
CirakClass cirakClass = new CirakClass();
int secim;
int say1, say2;
Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
secim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1. Sayıyı Giriniz : ");
say1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz : ");
say2 = Convert.ToInt32(Console.ReadLine());
switch (secim)
{
    case 1:
        cirakClass.Topla(say1, say2);
        break;
    case 2:
        cirakClass.Cikarma(say1, say2);
        break;
    case 3:
        cirakClass.Carpma(say1, say2);
        break;
    case 4:
        cirakClass.Bolme(say1, say2);
        break;
    default:
        Console.WriteLine("Yanlış işlem Brate");
        break;
}
Console.ReadKey();

/*
 * Okul Ana Claass
 * Öğretmen ve Öğrenci Alt Klass olacak
 * Program.cs'de de işlem yapacaksınız
 */