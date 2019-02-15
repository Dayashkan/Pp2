using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // переводит элементы массива с строки в числа
            int[][] array = new int[n][]; //создаём ступенчатый массив 
            for (int i=1; i <=n; i++) // цикл для строчек
            {
                for (int j=1; j <i; j++) // цикл для столбцов
                {
                    Console.Write("[*]"); // чтобы элементы записывались в строчку 
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
