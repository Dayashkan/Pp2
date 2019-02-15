using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\Users\Ceasar\Desktop\Pp2\week2\task1\input.txt", FileMode.Open, FileAccess.Read); // открывает файл стрим, открывает мой файл и считывает
            StreamReader sr = new StreamReader(fs); // открывает стримридер 
            string s = " ";
            s = sr.ReadLine(); // присваивает текст с файла в данный стринг 
            bool check = true;
            for ( int i =0; i < s.Length; i++) // пробегается по каждому элементу стринг
            {
                if (s[i]!=s[s.Length-i-1]) // проверяет одиннаковые ли элементы 
                {
                    check = false; // если разные то выходит с цикла 
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            sr.Close(); // закрывает считываемый файл и освобождает все ресурсы 
            fs.Close();
            Console.ReadKey();
        }
    }
}
