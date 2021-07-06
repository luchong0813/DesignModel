using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /// <summary>
    /// 番茄炒蛋(子类)
    /// </summary>
    public class Tomato : DodishTemplate
    {
        public override void carriedDishes()
        {
            Console.WriteLine("清洗并切西红柿，打鸡蛋。");
        }

        public override void doing()
        {
            Console.WriteLine("鸡蛋倒入锅里，然后倒入西红柿一起炒。");
        }

        public override void preparation()
        {
            Console.WriteLine("将炒好的西红寺鸡蛋装入碟子里");
        }
    }
}
