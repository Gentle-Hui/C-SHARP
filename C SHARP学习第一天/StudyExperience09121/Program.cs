using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09121
{
    class Program
    {
        static void Main(string[] args)
        {
            //三元表达式

            //先来个常规的if-else
            Console.WriteLine("请输入你的姓名，看看你上辈子的职业。");
            string name=Console.ReadLine();
            //if (name == "温荣辉")
            //{
            //    Console.WriteLine("淫才啊");
            //}
            //else {
            //    Console.WriteLine("流氓啊");
            //} Console.ReadKey();

            //再来个三元表达式形式的
            string result = name == "温荣辉" ? "淫才啊" : "流氓啊";
            Console.WriteLine(result);
            Console.ReadKey();
            //很明显代码更简约
        }
    }
}
