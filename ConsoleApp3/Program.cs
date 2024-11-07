using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int N = int.Parse(Console.ReadLine());
                if (N < 0)
                {
                    Console.WriteLine("Отрицательное число!");
                    return;
                }
                string result = "";
                while (N>0)
                {
                    result = result + (N % 2).ToString();
                    N = N / 2;
                }
                Console.WriteLine(result.Reverse().ToArray());
                Console.ReadKey();
            }
        }
    }
}
