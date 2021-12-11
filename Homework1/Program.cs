using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            var displayData = Task.Factory.StartNew(() =>
            {
                Random rnd = new Random();
                int[] values = new int[n];
                for (int ctr = 0; ctr <= values.GetUpperBound(0); ctr++)
                    values[ctr] = rnd.Next();

                return values;

            });
                                    
            Console.WriteLine(displayData.Result);
            Console.ReadKey();
        }
    }
}
