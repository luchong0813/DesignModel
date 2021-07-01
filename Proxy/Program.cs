using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /**
   * 模式：代理模式
   * 时间：2021-07-01
   * blog：https://www.cnblogs.com/chonglu/
   */
    class Program
    {
        /*
         * 假设现在有这样一个场景
         * 高中时小明喜欢小红，因为害羞等不好意思向隔壁班的小红表达爱意，于是就请小华代表他去向小红送礼物
         * 常规做法可能就是一个送礼物的类，一个女孩类，但这样导致的结果就是要么是小明送给小红，要么是小华送给小红
         * 但现在场景是小明委托小华送礼物给小红，他们之间存在一定的间接联系
         */
        static void Main(string[] args)
        {
            Girl xiaohong = new Girl() { Name = "小红" };

            Proxy xiaohua = new Proxy(xiaohong);
            xiaohua.GiveChocolate();
            xiaohua.GiveFlower();
            xiaohua.GiveLolly();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
