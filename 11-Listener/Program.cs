using _11_Listener.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Listener
{
    /**
    * 模式：观察者模式"最佳实战"
    * 时间：2021-08-17
    * blog：https://www.cnblogs.com/chonglu/
    */
    public class Program
    {
        static void Main(string[] args)
        {
            //订阅监听
            SubscriberManager.Register(1, EventEnum.Status1, HandlerMethod);
            SubscriberManager.Register(2, EventEnum.Status3, HandlerMethod2);

            //发布
            SubscriberManager.Publish(1, EventEnum.Status1);
            //SubscriberManager.Publish(2, EventEnum.Status3);

            Console.ReadKey();
        }

        //监听到发布事件后所要执行的处理方法
        private static void HandlerMethod2()
        {
            Console.WriteLine("执行方法2");
        }

        private static void HandlerMethod()
        {
            Console.WriteLine("执行方法1");
        }
    }
}
