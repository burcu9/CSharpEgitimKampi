using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x=başlangıç
            //y=bitiş
            //z=artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılma adedini girin: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i=1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i=0; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalvalue = 0;

            //for(int i=1; i<=10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for(int i=1; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalvalue);

            //int count = 0;
            //for(int i=1; i<=60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //1-2-4-8-16-..

            //int bacterium = 1;

            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " + bacterium);
            //}
            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //    işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazın

            //456

            //Console.Write("sayıyı girin:");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds,sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100; //4.56

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("toplamı: "+ sum);



            #endregion
            Console.ReadLine();
        }
    }
}
