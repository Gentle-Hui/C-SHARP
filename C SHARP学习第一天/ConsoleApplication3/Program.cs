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
            string str = "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";
            System.IO.File.WriteAllText(@"C:\Users\DELL\Desktop\GitToken.txt",str);
            Console.WriteLine("创建成功！");
            Console.ReadKey();
        }
    }
}
