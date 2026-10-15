using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region yazdırma komutları
            //Console.WriteLine("merhaba dünya");
            //Console.Write("selam");

            //Console.WriteLine("***** yemek kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-soğuk başlangıçlar");
            //Console.WriteLine("4-salatalar");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** yemek kategorileri *****");

            #endregion


            #region String  değişkenler

            //değişkenler

            //string
            //değişken_türü değişken_adı;

            //string name;
            //name = "burcu";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "burcu";
            //customerSurname = "korkmaz";
            //customerPhone = "0538 349 45 98";
            //customerEmail = "deneme@gmail.com";
            //district = "arifiye";
            //city = "sakarya";

            //Console.WriteLine("**** rezervasyon kartı****");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("müşteri: " + customerName +" "+ customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("adres: " + district+ " /"+ city);
            //Console.WriteLine("------------------");


            //customerName = "selin";
            //customerSurname = "sevim";
            //customerPhone = "0534 867 96 56";
            //customerEmail = "kimsin@gmail.com";
            //district = "cukurcuma";
            //city = "istanbul";

            //Console.WriteLine("---------------");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("adres: " + district + " /" + city);
            //Console.WriteLine("------------------");






            #endregion

            #region İnt değişkenler


            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** restoran menü fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "tl");
            Console.WriteLine("-----pizza: " + pizzaPrice + "tl");
            Console.WriteLine("-----kola: " + cokePrice + "tl");
            Console.WriteLine("-----limonata: " + lemonadePrice + "tl");
            Console.WriteLine("-----kızartma: " + friesPrice + "tl");
            Console.WriteLine("-----su: " + waterPrice + "tl");

            Console.WriteLine();

            Console.WriteLine("**** restoran menü fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("---------");
            Console.WriteLine("hamburger tuttarı: " +totalHamburgerPrice+ " TL ");
            Console.WriteLine("pizza tuttarı: " +totalPizzaPrice+ " TL ");
            Console.WriteLine("fries tuttarı: " +totalFriesPrice+ " TL ");
            Console.WriteLine("coke tuttarı: " +totalCokePrice+ " TL ");
            Console.WriteLine("lemonaade tuttarı: " +totalLemonadePrice+ " TL ");
            Console.WriteLine("water tuttarı: " +totalWaterPrice+ " TL ");

            Console.WriteLine();

            int totalPrice = totalLemonadePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalCokePrice + totalHamburgerPrice;
            Console.WriteLine("toplam tutar:" + totalPrice+ "TL ");
            
            #endregion


            Console.Read();



       
        }
    }
}




//yazdırma komutları
