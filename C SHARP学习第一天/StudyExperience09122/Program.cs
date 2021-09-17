using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09122
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用死循环特性
            //while(true){
            //产生随机数
            //Random r=new Random();
            //int rNumber = r.Next(1,1000);
            //Console.WriteLine(rNumber);
            //Console.ReadKey();
            //}

            //这个逼上辈子是干什么的？
            Random r = new Random();
            Console.WriteLine("输入你的姓名就能知道你上辈子是个什么东西了！");
            while (true)
            {
                int rNumber = r.Next(1, 20);
                string name = Console.ReadLine();
                switch (rNumber)
                {
                    #region 输入你的姓名就能知道你上辈子是个什么东西了！
                    case 1: Console.WriteLine("{0}上辈子是吃翔的", name);
                        break;
                    case 2: Console.WriteLine("{0}上辈子是拉翔的", name);
                        break;
                    case 3: Console.WriteLine("{0}上辈子就是坨翔", name);
                        break;
                    case 4: Console.WriteLine("{0}上辈子是酒懵子", name);
                        break;
                    case 5: Console.WriteLine("{0}上辈子是拉皮条的", name);
                        break;
                    case 6: Console.WriteLine("{0}上辈子是老鸨子", name);
                        break;
                    case 7: Console.WriteLine("{0}上辈子是老鸨子的头牌", name);
                        break;
                    case 8: Console.WriteLine("{0}上辈子是救苦救难的活菩萨", name);
                        break;
                    case 9: Console.WriteLine("{0}上辈子是天下闻名的侠士", name);
                        break;
                    case 10: Console.WriteLine("{0}上辈子是富甲天下的大老板", name);
                        break;
                    case 11: Console.WriteLine("{0}上辈子是个家里蹲", name);
                        break;
                    case 12: Console.WriteLine("{0}上辈子是个小鬼子", name);
                        break;
                    case 13: Console.WriteLine("{0}上辈子是个非主流", name);
                        break;
                    case 14: Console.WriteLine("{0}上辈子是花天酒地的富家公子", name);
                        break;
                    case 15: Console.WriteLine("{0}上辈子是个一贫如洗的清官", name);
                        break;
                    case 16: Console.WriteLine("{0}上辈子是个大贪官", name);
                        break;
                    case 17: Console.WriteLine("{0}上辈子是皇上身边的大太监", name);
                        break;
                    case 18: Console.WriteLine("{0}上辈子是坐拥天下的皇上", name);
                        break;
                    case 19: Console.WriteLine("{0}上辈子是皇上最宠爱的妃子", name);
                        break;
                    case 20: Console.WriteLine("{0}上辈子是个狗", name);
                        break;
                    #endregion
                }
            } 
        }
    }
}
