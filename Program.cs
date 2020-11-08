using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 1;
            int numb2 = 1;
            //--- Ввод цисел ---
            Console.Write("Сколько будет чисел в массиве?\nСтроки:  ");
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы: ");
            numb = Convert.ToInt32(Console.ReadLine());
            //--- Массив ---
            Random r = new Random();
            string y = "";
            int[,] mas = new int[numb, numb2];
            for (int i = 0; i < numb; i++)
            {
                for (int j = 0; j < numb2; j++)
                {
                    mas[i,j] = r.Next(0, 100); //--- Генерация цисел в массив ---
                }
            }
            //--- Цикл ---
            bool restart = false;
            do
            {
                
                for (int i = 0; i < numb; i++)
                {
                    for (int j = 0; j < numb2; j++)
                        Console.Write(mas[i, j] + " "); //--- Вывод цесел массива ---
                    Console.Write("\n");
                }
                Console.WriteLine("Для очистки массива, введите cancel");
                y = Console.ReadLine();
                if (y == "cancel")
                {
                    for (int i = 0; i < numb; i++)
                    {
                        for (int j = 0; j < numb2; j++)
                        {
                            mas[i, j] = 0;
                            Console.Write(mas[i, j] + " "); //--- Очистка массива и вывод ---
                        }
                        Console.Write("\n");
                    }
                    restart = false;
                }
                else
                {
                    Console.WriteLine("      Error\n"); //--- Если "cancel" не был введён ---
                    restart = true;
                }
            }
            while (restart == true);
            
            Console.ReadKey();
        }
    }
}