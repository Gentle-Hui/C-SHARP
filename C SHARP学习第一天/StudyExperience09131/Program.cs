using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09131
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法求数组的最大值最小值平均值总和
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //将要返回的四个值也放到一个数组中
            int[] result = Program.GetResult(number);
            Console.WriteLine("得知最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",result[0],result[1],result[2],result[3]);
            Console.ReadKey();
        }
        public static int[] GetResult(int[] num)
        {
            int[] res = new int[4];
            //假设res[0]是最大值，res[1]是最小值，res[2]是总和，res[3]是平均值
            res[0] = num[0];
            res[1] = num[0];
            res[2] = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > num[0])
                {
                    res[0] = num[i];
                }
                if (num[i] < num[1])
                {
                    res[1] = num[i];
                }
                res[2] = res[2] + num[i];
            }
            res[3] = res[2] / num.Length;
            return res;
        }
    }
}
