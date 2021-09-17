using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0916
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一题：有一个字符串数组{“迈克尔乔丹”，“勒布朗詹姆斯”，“科比布莱恩特”，“凯文杜兰特”，“拉塞尔威斯布鲁克”，“保罗乔治”}
            //找到其中最长的字符串
            //string[] names = { "迈克尔乔丹", "勒布朗詹姆斯", "科比布莱恩特", "凯文杜兰特", "拉塞尔威斯布鲁克", "保罗乔治" };
            //string TheLongist;
            //LongistName(names, out TheLongist);
            //Console.WriteLine(TheLongist);      
            //Console.ReadKey();

            //第二题
        }
        public static void LongistName(string[] name, out string TheLongist)
        {
            TheLongist = name[0];
            for (int i = 0; i < name.Length; i++)
            {
                int length = name[0].Length;

                if (name[i].Length > TheLongist.Length)
                {
                    TheLongist = name[i];
                }
            }
        }
    }
}
