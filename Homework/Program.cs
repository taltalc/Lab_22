using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Summ()
        {


            int n;
            int[] numbers= new int[n];
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += numbers[i];
            }
            Console.WriteLine($"Сумма чисел массива {Sum}");


        }
        static void Max(Task task2, object[] numbers2)
        {
            int[] numbers = Array.ConvertAll(object, i => (int)i);
            int max = numbers[0];
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;

                }
            }
            Console.WriteLine($"Максимальное число в массиве: {max}");


        }


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
            Task task1 = new Task(Summ);

        }
    } }

