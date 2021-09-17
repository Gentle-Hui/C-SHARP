using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0911
{
    class Program
    {
        static void Main(string[] args)
        {
            //一个成绩对比系统，要求算出两个同学的总成绩对比两个同学的总成绩好坏
            Console.WriteLine("请输入第一个同学的姓名：");
            string name1 = Console.ReadLine();
            Console.WriteLine("请输入第一个同学的语文成绩：");
            double chinese1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第一个同学的数学成绩：");
            double math1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第一个同学的英语成绩：");
            double english1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个同学的姓名：");
            string name2 = Console.ReadLine();
            Console.WriteLine("请输入第二个同学的语文成绩：");
            double chinese2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个同学的数学成绩：");
            double math2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个同学的英语成绩：");
            double english2 = Convert.ToDouble(Console.ReadLine());

            bool d = chinese1 + math1 + english1 > chinese2 + math2 + english2;
            if (d)
            {
                Console.WriteLine("从总成绩的角度出发{0}的成绩更加突出。", name1);
            }
            else
            {
                Console.WriteLine("从总成绩的角度出发{0}的成绩更加突出", name2);
            } Console.ReadKey();
        }
    }
}
