using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2-4-6-8
            //sarı,kırmızı,mavi
            //Değişken türü [] Diziadı =new Değişken türü[eleman sayısı]

            //string [] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[5]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 47;
            //numbers[2] = 67;
            //numbers[3] = 89;
            //numbers[7] = 798;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "atina", "ankara", "istanbul" };
            // Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "kırmızı", "sarı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7458, 2365, 1120 };

            //for(int i=0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', '*', '/', '-' };
            //for(int i=0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i=0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali","ahmet", "ayşe", "fatma", "mehmet", "mustafa" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520 };
            //Array.Sort(numbers);//küçükten büyüğe
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520 };
            //Array.Reverse(numbers);//diziyi tersten yazdırıyo
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index=Array.IndexOf(customers, "merve");//kaçıncı index olduğunu söyle
            //Console.WriteLine(index);

            //int[] numbers = { 45, 86, 98, 63, 74, 25, 36 };
            //Console.WriteLine("dizinin en büyük elemanı:" + numbers.Max() + "dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"lütfen {i + 1}.şehri giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------");

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 10, 20, 30, 40, 50 ,123,242,7645,8657,324,};
            //Console.WriteLine("çift sayılar:");

            //for(int i=0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("tek sayılar:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion

            Console.ReadLine();
        }
    }
}
