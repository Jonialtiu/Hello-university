using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiuProgramKv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[20];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Если хотите очистить массив, введите cancel");
            string y = Console.ReadLine();
            if (y == "cancel")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0);
                    Console.WriteLine(mas[i]);
                }
            } else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }

            Console.ReadKey();
        }
    }
}