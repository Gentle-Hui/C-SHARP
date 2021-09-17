using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09113
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据类型转换的三种方式
            int str = Convert.ToInt32("123");//简单易懂型，失败了直接抛异常
            int str2 = int.Parse("1234");//熟记使用型，失败了直接抛异常
            int str3 = 0;//实际适用型，失败会提示false并返回0
            bool a = int.TryParse("12345a",out str3);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(a);
            Console.WriteLine(str3);
            Console.ReadKey();
        }
    }
}
