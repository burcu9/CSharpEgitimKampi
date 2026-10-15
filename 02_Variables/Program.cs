using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        private static readonly object potatoGram;

        static void Main(string[] args)
        {

            #region  Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("****Fiyat List****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---Elma Birim Fİyatı:" + applePrice +"TL");
            //Console.WriteLine("---Portakal Birim Fİyatı:" + orangePrice + "TL");
            //Console.WriteLine("--Çilek Birim Fİyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---Patates Birim Fİyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---Domates Birim Fİyatı:" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Elmanın Toplam Fiyatı: "+ "gramı: "+ appleGram+ " birim fiyatı: "+ applePrice + " toplamı: " + appleTotalPrice);

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Portakalın Toplam Fiyatı: " + "gramı: " + orangeGram + " birim fiyatı: " + orangePrice + " toplamı: " + orangeTotalPrice);

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Çileğin Toplam Fiyatı: " + "gramı: " + strawberryGram + " birim fiyatı: " + strawberryPrice + " toplamı: " + strawberryTotalPrice);

            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Patatesin Toplam Fiyatı: " + "gramı: " + potatoGram + " birim fiyatı: " + potatoPrice + " toplamı: " + potatoTotalPrice);

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Domatesin Toplam Fiyatı: " + "gramı: " + tomatoGram + " birim fiyatı: " + tomatoPrice + " toplamı: " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice  + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("alısveris toplam tutar: " + shoppingTotalPrice + "TL");








            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF..
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();


            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("----------");
            //Console.WriteLine("Yolcu kimlik no: "+ passengerIdentityNumber+ "yolcu adı soyadı: " + passengerName + passengerSurname+ " "+ passengerDistrict+ "/"+ passengerCity+ " " +passengerAge );


            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            ////ABC12D

            //int shoesPrices, computerPrice, chairPrice, tvPrice;
            //shoesPrices = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;


            //Console.Write("lütfen ayakkabı sayısı giriniz: ");
            //shoesCount =int.Parse( Console.ReadLine());

            //Console.Write("lütfen bilgisayar sayısı giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen sanldaye sayısı giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen tv sayısı giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrices*shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("toplam tutar:" + totalPrice);

            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri  

            //double exam1, exam2, exam3, result;

            //Console.Write("1.sınav notu girin: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.sınav notu girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.sınav notu girin: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ort: " + result);

            #endregion



            #region Klavyeden karakter girişi

            //char gender;
            //Console.Write("cinsiyet seç: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğin cinsiyet: " + gender);

            #endregion



            Console.Read();



        }
    }
}
