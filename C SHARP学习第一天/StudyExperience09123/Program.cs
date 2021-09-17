using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09123
{
    //将枚举声明到命名空间下面，命名空间内的类都能使用枚举
    public enum Gender { 
    男,
    女
    }
    //创建一个结构
    public struct Person {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //枚举
        //【public】enum 枚举名字{
        //值1，
        //值2，
        //。。。。。。
        //}
            Gender a = Gender.男;
        }
    }
}
