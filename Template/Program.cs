using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /**
    * 模式：模板模式
    * 时间：2021-07-06
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------酸辣土豆丝----------------------");
            DodishTemplate potatoe = new Potatoes();
            potatoe.dodish();
            Console.WriteLine("----------------------番茄炒蛋----------------------");
            DodishTemplate tomato = new Tomato();
            tomato.dodish();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
