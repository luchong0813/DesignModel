using Observer.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /**
    * 模式：观察者模式
    * 时间：2021-07-12
    * blog：https://www.cnblogs.com/chonglu/
    */
    public class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            ConcertSubject sub = new ConcertSubject();

            sub.Addach(new ConcertObserver(sub, "1"));
            sub.Addach(new ConcertObserver(sub, "2"));
            sub.Addach(new ConcertObserver(sub, "3"));

            sub.State = "online";
            sub.Notify();

            Console.WriteLine("---------------事件委托实现---------------");
            //前台（发布者）
            Receptionist receptionist = new Receptionist();

            //某员工（订阅者）
            EmployeeA employeeA = new EmployeeA("摸鱼小鲁", receptionist);

            receptionist.Update += new MyDelegate(employeeA.CloseTV);

            //发布者状态
            receptionist.SubjectState = "前台小姐姐说看到Boss回来了";
            //发出通知
            receptionist.Notify();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }

    }
}
