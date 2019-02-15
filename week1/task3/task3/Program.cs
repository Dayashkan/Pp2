using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // определяем размер массива по вводу с клавиатуры
            var length = Convert.ToInt32(Console.ReadLine());
            // преобразует строковое представление числа в эквивалентное 32-битовое знаковое число
            int[] array = new int[length]; // объявляем массив 
            string s = Console.ReadLine(); // заполняем массив
            string[] array1 = s.Split(); // пробелы между элементами массива
            for (int i = 0; i < length; i++) // запускается цикл, чтобы индикатор пробегался по всем элементам массива и конвертировал их в int 
            {
                array[i] = int.Parse(array1[i]);
            }
            for (int i = 0; i < length; i++) // запускается цикл для вывода каждого элемента 
            {
                Console.Write(array[i]);
                Console.Write(array1[i]);
            }
            Console.ReadKey();


        }
    }
}
