using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("şifreyi gir: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("başkenti girin: ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi girin: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğru");
            //}
            //else
            //{
            //    Console.Write("Hatali bilgi.");
            //}

            //int number;
            //Console.Write("sayıyı girin: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış.");
            //}

            //int exam1, exam2, exam3, average;
            //string result="hata";

            //Console.Write("sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav ortalaması: " + average);

            //if(average>50 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}

            //if (average > 84 )
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("şehir girin: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("kullanıcı adı girin:");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul değil.");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz.");
            //}

            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.sayıyı girin:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı girin:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Sayıyı girin:");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları 
            //char team;
            //Console.Write("Takım sembolü girin: ");
            //team = char.Parse(Console.ReadLine());

            //if (team=='g' | team =='G')
            //{
            //    Console.Write("galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("beşiktaş");
            //}



            #endregion


            #region Örnek Proje Uygulaması 

            //Console.WriteLine("****** C# EĞİTİM KAMPI RESTORANI******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //Console.WriteLine("1-ana yemekler");
            //Console.WriteLine("2-çorbalar");
            //Console.WriteLine("3-pizzalar");
            //Console.WriteLine("4-içecekler");
            //Console.WriteLine("5-tatlılar");

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("detayını görmek istediğin menüyü seç:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana yemekler--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-köri soslu tavuk");
            //    Console.WriteLine("2-kızartma tabağı");
            //    Console.WriteLine("3-fasülye pilav");
            //    Console.WriteLine("4-fırında somon");
            //    Console.WriteLine("5-patlıcan musakka");
            //    Console.WriteLine("-------------------------------");
            //}
            //Console.WriteLine();


            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-mercimek çorbası");
            //    Console.WriteLine("2-ezogelin çorbası");

            //    Console.WriteLine("-------------------------------");
            //}
            //Console.WriteLine();

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-akdeniz pizza");
            //    Console.WriteLine("2-margeraita");
            //    Console.WriteLine("3-tavuklu pizza");

            //    Console.WriteLine("-------------------------------");
            //}
            //Console.WriteLine();

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-ayran");
            //    Console.WriteLine("3-su");

            //    Console.WriteLine("-------------------------------");
            //}
            //Console.WriteLine();

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliçe");
            //    Console.WriteLine("2-kazandibi");
            //    Console.WriteLine("3-sütlaç");

            //    Console.WriteLine("-------------------------------");
            //}
            //Console.WriteLine();


            #endregion


            #region Switch Case

            //Console.Write("lütfen ay girişi yap: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubar"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("hatalı giriş"); break;

            //}



            #endregion


            #region  Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı girin:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı girin:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("yapmak istediğin işlemi seç: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("çıkarma: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;
            //}


            #endregion


            Console.Read();
        }
    }
}
