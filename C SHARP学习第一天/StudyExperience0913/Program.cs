using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0913
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个数字，判断是否是数字，如果不是就提示请输入数字
            Console.WriteLine("请输入一个数字：");
            string input = Console.ReadLine();
            Console.WriteLine(Inspect(input));
            Console.ReadKey();

        }

        public static int Inspect(string a)
        {
            while (true)
            {
                try
                {
                    int b = Convert.ToInt32(a);
                    return b;
                }
                catch
                {
                    Console.WriteLine("请重新输入一个数字。");
                    a = Console.ReadLine();
                }
            }
        }
    }
}
