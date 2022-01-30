using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Task _ = FactorialAsync(f);
                        
            for (int i = 0; i <= f; i++)
            {
                Console.WriteLine('*');
                Thread.Sleep(700);
            }
            Console.ReadKey();
        }
        static async Task FactorialAsync(int num)
        {
            Console.WriteLine("Этапы расчета:");
            int res = await Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                    Console.WriteLine($"{result,10}");
                    Thread.Sleep(500);
                }
                return result;
            });
            Console.WriteLine($"Факториал числа равен {res}");
        }
    }
}
