using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0915
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，求数组元素的最大值最小值总和和平均值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //调用这个方法
            int Max = 0;
            int Min = 0;
            int sum = 0;
            int avg = 0;
            GetResult(numbers, out Max, out Min, out sum, out avg);
            Console.WriteLine(Max);
            Console.WriteLine(Min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();
        }

        public static void GetResult(int[] num, out int Max, out int Min, out int sum, out int avg)
        {
            Max = num[0];
            Min = num[0];
            sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > num[0])
                {
                    Max = num[i];
                }
                if (num[i] > Min)
                {
                    Min = num[i];
                }
                sum += num[i];
            }
            avg = sum / num.Length;
        }
    }
}
