using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studyexperience09111
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个姓名然后显示出这个人上辈子的职业
            Console.WriteLine("请输入一个人的姓名，我们会显示出这个人上辈子的职业。");
            string name = Console.ReadLine();
            //老赵，老钱，老孙，老李，老王，老刘，老温
            switch (name)
            {
                case "老赵": Console.WriteLine("上辈子是默默无闻的小演员。");
                    break;
                case "老钱": Console.WriteLine("上辈子是开钱庄的。");
                    break;
                case "老孙": Console.WriteLine("上辈子是公务员。");
                    break;
                case "老李": Console.WriteLine("上辈子是勤俭持家的好男人。");
                    break;
                case "老王": Console.WriteLine("上辈子是个当兵的。");
                    break;
                case "老刘": Console.WriteLine("上辈子是个气管炎。");
                    break;
                case "老温": Console.WriteLine("上辈子是个家里蹲。");
                    break;
                default: Console.WriteLine("不认识，估计是一坨翔。");
                    break;
            } Console.ReadKey();

        }
    }
}
