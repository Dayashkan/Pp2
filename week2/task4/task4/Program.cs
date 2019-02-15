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
            //writing somethimg to our text file
            StreamWriter sw = new StreamWriter(@"D:\Users\Ceasar\Desktop\Pp2\week2\task4\path\ex.txt");
            sw.Write("hi");
            sw.Close();
            string path = (@"D:\Users\Ceasar\Desktop\Pp2\week2\task4\path\ex.txt");
            string path1 = (@"D:\Users\Ceasar\Desktop\Pp2\week2\task4\path1\ex.txt");
            //copying the file
            File.Copy(path, path1);
            File.Delete(path);
            sw.Close();
            Console.ReadKey();

        }
    }
}
