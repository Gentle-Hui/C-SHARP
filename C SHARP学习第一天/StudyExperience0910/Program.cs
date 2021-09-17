using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0910
{
    class Program
    {
        static void Main(string[] args)
        {
            //question编程实现几天是几周零几天 

            //int days = 82;
            //int weeks = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);
            //Console.ReadKey();


            //Convert类型转换工厂

            //string str = "123";
            //double a = Convert.ToDouble(str);
            
            //Console.WriteLine(a);
            //Console.ReadKey();


            //用户输入姓名，语文，数学，英语成绩，系统给出总成绩和平均分
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            try
            {
                Console.WriteLine("请输入你的语文成绩：");
                double chinese = Convert.ToDouble(Console.ReadLine());
                //string chinese = Console.ReadLine();
                Console.WriteLine("请输入你的数学成绩：");
                double math = Convert.ToDouble(Console.ReadLine());
                //string math = Console.ReadLine();
                Console.WriteLine("请输入你的英语成绩：");
                double english = Convert.ToDouble(Console.ReadLine());
            
            //string english = Console.ReadLine();
            //这里如果我们在算总成绩的时候直接将三个string类型的字符串相加的话，例如语数外分别为66，77，88的时候，会出现总成绩667788的情况，所以我们需要把他转换成数字类型去计算。
            //double dbchinese = Convert.ToDouble(chinese);
            //double dbmath = Convert.ToDouble(math);
            //double dbenglish = Convert.ToDouble(english);
            Console.WriteLine("姓名：{0}\n总成绩：{1}\n平均分：{2}\n", name, chinese + math + english, (chinese + math + english)/3);
            }
            catch
            {
                Console.WriteLine("输入的成绩格式有误。");
            }
            Console.ReadKey();
        }
    }
}
