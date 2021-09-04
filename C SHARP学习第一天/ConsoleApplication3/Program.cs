using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //在桌面创建一个文本文档
            string str = "今天是个好日子！";
            System.IO.File.WriteAllText(@"C:\Users\DELL\Desktop\TextDemo.txt",str);
            Console.WriteLine("创建成功！");
            Console.ReadKey();
        }
    }
}
