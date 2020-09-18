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
            bool reset = false;
            int number = 1;
            Console.Write("Сколько будет чисел в массиве?\nЧисло: ");
            number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            string y = "";
            int[] mas = new int[number];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, number);
            }
            do {
                for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Если хотите очистить массив, введите cancel");
            y = Console.ReadLine();
            if (y == "cancel")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = 0;
                    Console.WriteLine(mas[i]);
                    reset = false;
                }
            } else
            {
                Console.WriteLine("      Error\n");
                reset = true;
            }
            }
            while (reset == true);
            Console.ReadKey();
        }
    }
}
