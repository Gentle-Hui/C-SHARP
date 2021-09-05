using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0904
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            //强制类型转换
            double d = Convert.ToDouble(str);
            //转什么，to什么
            Console.WriteLine("字符串被转换为{0}.", d);
            Console.ReadKey();
        }
    }
}
