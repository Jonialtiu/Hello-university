using System;
using System.IO;

namespace CodeGray
{
    class Program
    {
        static bool[][] GraysCode(int n)
        {
            bool[][] num = new bool[(int)Math.Pow(2, n)][];
            if (n == 1)
            {
                num[0] = new bool[1];
                num[1] = new bool[1];
                num[0][0] = false;
                num[1][0] = true;
            }
            else
            {
                bool[][] oldCode = GraysCode(n - 1);
                int length = (int)Math.Pow(2, n) / 2;
                for (int i = 0; i < length; i++)
                {
                    num[i] = new bool[n];
                    for (int j = 0; j < n - 1; j++)
                        num[i][j] = oldCode[i][j];
                    num[i][n - 1] = false;
                }
                Array.Reverse(oldCode);
                for (int i = 0; i < length; i++)
                {
                    num[i + length] = new bool[n];
                    for (int j = 0; j < n - 1; j++)
                        num[i + length][j] = oldCode[i][j];
                    num[i + length][n - 1] = true;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            string[] Arr;
            int Size = 0;
            bool done = false;
            while (!done)
            {
                Console.Write("Введите размер массива:");
                if (int.TryParse(Console.ReadLine(), out Size) == false)
                    Console.WriteLine("Можно ввести только число!");
                else
                    if (Size < 1 || Size > 7)
                        Console.WriteLine("Размер должен быть больше нуля и меньше 8!");
                    else
                        done = true;
            }
            Arr = new string[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"Введите элемент под номером {i + 1}:");
                Arr[i] = Console.ReadLine();
                if (Arr[i] == "" || Arr[i] == " ")
                    Arr[i] = $"{(i + 1)}";
            }
            bool[][] grCode = GraysCode(Size);
            int aSize = (int)Math.Pow(2, Size);
            Char[] chr = { ' ', ',' };
            Console.WriteLine("Код: ");
            for (int i = 0; i < aSize; i++)
            {
                Console.Write($"Y{i + 1} => ");
                for (int j = 0; j < Size; j++)
                    if (grCode[i][j])
                        Console.Write("1");
                    else
                        Console.Write("0");
                Console.Write(" --> ");
                string staple = "{";
                for (int j = 0; j < Size; j++)
                    if (grCode[i][j])
                        staple += Arr[j].ToString() + ", ";
                staple = staple.TrimEnd(chr);
                staple += "}";
                Console.Write(staple);
                Console.WriteLine();
            }
        }
    }
}
