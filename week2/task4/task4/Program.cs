using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = (@"D:\Users\Ceasar\Desktop\Pp2\week2\task4\path\ex.txt");
            string path1 = (@"D:\Users\Ceasar\Desktop\Pp2\week2\task4\path1\ex.txt");
            FileStream fs = File.Create(path);
            fs.Close();
            
            //copying the file
            File.Copy(path, path1, true);
            Console.ReadKey();

        }
    }
}
