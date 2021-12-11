using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                 Console.Write("Введите размерность массива:");
                 int n = Convert.ToInt32(Console.ReadLine());

                 int[] numbers = new int[n];
                 Random random = new Random();
                 for (int i = 0; i < n; i++)
                 {
                     numbers[i] = random.Next(-100, 100);
                     Console.WriteLine($"{numbers[i]}");

                 }

            var Sum = new Task(() =>
             {
                 int sum = 0;
                 for (int i = 0; i < numbers.Length; i++)
                 {
                     sum += numbers[i];
                 }
                 Console.WriteLine($"Сумма чисел массива: {sum}");
             });
            var Max = Sum.ContinueWith((t) =>
              {
                  int max = numbers[0];
                  foreach (int item in numbers)
                  {
                      if (item > max)
                      {
                          max = item;

                      }
                  }
                  Console.WriteLine($"Максимальное число в массиве: {max}");

              });
            Sum.Start();
            Console.ReadKey();
        }
    }
}
