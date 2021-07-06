using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /**
    * 模式：原型模式
    * 时间：2021-07-05
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume1 = new Resume() { Name = "张三", Age = 22, Sex = "女" };
            resume1.SetWorkExperince("2019-2020", "MicroSoft");

            Resume resume2 = (Resume)resume1.Clone();
            resume1.SetWorkExperince("2019-2020", "Tencent");

            Resume resume3 = (Resume)resume1.Clone();
            resume1.SetWorkExperince("2019-2020", "AliBaba");

            resume1.Display();
            resume2.Display();
            resume3.Display();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
