using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach(1;2;3;4)

            //  1:    değişken türü
            //  2:    değişken adı
            //  3:    In
            //  4: liste koleksiyon, dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 134, 2656, 367, 456, 5456, 646, 3467, 83465, 3469 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 134, 2656, 367, 456, 5456, 646, 3467, 83465, 3469 };
            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 134, 2656, 367, 456, 5456, 646, 3467, 83465, 3469 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine("toplam:" + total);



            //List<int> numbers= new List<int>()
            //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# EĞİTİM KAMPI SINAV UYGULAMASI *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////sınıftaki öğrenci sayısını kullanıcıdan alma 
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            //double totalExamResult = 0;

            //for (int i=0; i <studentCount; i++)
            //{
            //    Console.WriteLine($" {i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i]= Console.ReadLine();

            //    //double totalExamResult = 0;

            //    //her öğrenci icin 3 sınav notu girişi

            //    for (int j=0;j<3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz 
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i]=totalExamResult / 3; //ortalama hesaplama

            //}

            ////sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");


            //    //öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($" {studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            Console.ReadLine();
        }
    }
}
