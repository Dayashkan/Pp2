using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isPrime(int x) // функция для определения простых чисел 
            {
                
  
                if (x == 1) return false;
                if (x == 2) return true;
                if (x == 3) return true;
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0) return false;
                }
                return true;
            }

            FileStream fs = new FileStream(@"D:\Users\Ceasar\Desktop\Pp2\week2\task2\input.txt", FileMode.Open, FileAccess.Read); // открывает файл и считывает его 
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine(); //заполняет стринг значениями с файла 
            string[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // праметрам передаётся StringSplitOptions, определяющее исключать ли пустые строки 
            int[] a = new int[parts.Length];

            for (int i = 0; i < a.Length; i++) // цикл для конвертирования строки в числа 
            {
                a[i] = int.Parse(parts[i]);
            }

            FileStream fs1 = new FileStream(@"D:\Users\Ceasar\Desktop\Pp2\week2\task2\output.txt", FileMode.OpenOrCreate, FileAccess.Write); // открывает файл  и записывает результаты
            StreamWriter sw = new StreamWriter(fs1); // открывает стрим райтер 
            string ans = "";
            for (int i = 0; i < a.Length; i++) // 
            {
                if (isPrime(a[i])==true)
                {
                    ans += a[i] + " "; // добавляет простые числа 
                }
            }
            sw.Write(ans);
            sw.Close();
            fs1.Close();


            sr.Close();
            fs.Close();
            Console.ReadKey();
        }




    }
}
