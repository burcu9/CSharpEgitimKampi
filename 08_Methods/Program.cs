using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen metotlar
            //customer --> listele, ekle, sil,güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("ali");
            //    Console.WriteLine("esma");
            //    Console.WriteLine("çınar");
            //    Console.WriteLine("merve");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen  Stirng Parametreli Metotlar 

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("ali keskin");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("müşteri: " + name + " " + surName);
            //}

            //CustomerCard("burcu", "korkmaz");
            //CustomerCard("ali", "yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "buse yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Stirng Parametreli Metotlar

            // string CountryCard(string countryName, string capital, string flagColor)
            // {
            //     string cardInfo = "Ülke: " + countryName + " başkent: " + capital + " bayrak rengi: " + flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;

            // Console.Write("ülke adı girin:");
            // x = Console.ReadLine();

            // Console.Write("başkent adı girin:");
            // y=Console.ReadLine();

            //Console.Write("bayrak rengi girin:");
            // z= Console.ReadLine();

            // Console.WriteLine(CountryCard(x, y, z));

            // Console.WriteLine(CountryCard("türkiye", "ankara", "kırmızı"));

            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(23, 54));
            //Console.WriteLine(Sum(36, 21));
            //Console.WriteLine(Sum(44, 98));
            //Console.WriteLine(Sum(12, 45));
            #endregion


            #region sınav uygulaması 

            //string ExamResult (string student, int exam1, int exam2, int exam3)
            //{
            //    int result =(exam1+exam2+exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavdan geçti "+ "ortalama"+ result;
            //    }
            //    else
            //    {
            //        return " isimli öğrenci başarısız oldu "+ "ortalama" + +result ;
            //    }
            //}

            //Console.WriteLine(ExamResult("ali", 53, 30, 92));
            //Console.WriteLine(ExamResult("selma", 45, 34, 80));

            #endregion

            Console.ReadLine();
        }
    }
}
