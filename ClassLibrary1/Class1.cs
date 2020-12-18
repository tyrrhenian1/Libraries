using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Summa(int [,] mas)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            int max = mas[0, 0];
            int min = mas[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mas[i, i] > max) max = mas[i, i];
                    if (mas[i, i] < min) min = mas[i, i];
                }
            }
            return max + min;
        }
    }
}
