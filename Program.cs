using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 18
Элементы заданной матрицы A(N, M) переписывайте построчно в одномерный
массив до тех пор, пока не встретится нулевой элемент. */

namespace _4_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   { 8, 7, 6, -4, 8 },
                { 4, 1, 5, -7, 8 },
                { 7, 8, 9, 0, 2 },
                { 12, 0, 3, -4, 5 }  };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)            
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] != 0)                    
                        list.Add(arr[i, j]);                    
                    else
                        goto Exit;
                }            
            Exit:
            foreach(int l in list)
                Console.Write($"{l}, ");
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
