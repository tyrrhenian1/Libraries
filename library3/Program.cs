using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace library3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите кол-во строк матрицы: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во cтолбцов матрицы: ");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(50) - 25;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма минимального и максимального элементов главной диагонали: " + ClassLibrary1.Class1.Summa(array));
            Console.ReadKey();
        }
    }
}
