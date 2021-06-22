using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
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
                Operation operation = null;
                operation = OperationFactory.CreateOperation(oper);
                operation.NumA = Convert.ToDouble(num1);
                operation.NumB = Convert.ToDouble(num2);
                Console.WriteLine($"结果：{operation.GetResult()}");
            }
        }
    }
}
