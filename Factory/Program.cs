using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /**
    * 模式：工厂模式
    * 时间：2021-07-01
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------计算器-------------------");
                Console.WriteLine("请输入第一个数：");
                var num1 = Console.ReadLine();
                Console.WriteLine("请输入运算符（“+ or -”）：");
                var oper = Console.ReadLine();
                Console.WriteLine("请输入第二个数：");
                var num2 = Console.ReadLine();

                IFactory factory;
                Operation operation = null;
                switch (oper)
                {
                    case "+":
                        factory = new AddFactory();
                        operation = factory.CreateOperation();
                        operation.NumA = Convert.ToDouble(num1);
                        operation.NumB = Convert.ToDouble(num2);
                        break;
                    case "-":
                        factory = new SubFactory();
                        operation = factory.CreateOperation();
                        operation.NumA = Convert.ToDouble(num1);
                        operation.NumB = Convert.ToDouble(num2);
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"结果：{operation.GetResult()}");
            }
        }
    }
}
