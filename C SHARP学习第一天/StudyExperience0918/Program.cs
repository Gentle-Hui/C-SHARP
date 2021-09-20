using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0918
{
    class Program
    {
        static void Main(string[] args)
        {
            //将对象实例化
            Person data = new Person();
            data.Age = 23;
            data.Gender='男';
            data.Name = "张三";
            data.PersionalData();
            Console.ReadKey();
        }
    }
}
