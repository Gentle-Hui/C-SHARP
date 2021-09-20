using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience0918
{
    public class Person
    {
        //字段存储数据
        string _name;
        int _age;
        char _gender;

        public char Gender1
        {
            get { return _gender; }
            set { _gender = value; }
        }
        //属性控制数据
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age { set { _age = value; } get { return _age; } }
        public char Gender { set { _gender = value; } get { return _gender; } }

        //方法使用数据
        public void PersionalData (){
            Console.WriteLine("{0}同学是{1}生，今年{2}岁了",this.Name,this.Gender,this.Age);
        }
    }
}
