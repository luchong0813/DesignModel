using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 追求者类（类比为小明）
    /// 继承送礼物接口，实现
    /// 因为这些礼物是小明要送给小红的
    /// </summary>
    public class Purist : IGaveGift
    {
        private Girl _girl;
        public Purist(Girl girl)
        {
            _girl = girl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"送了一盒巧克力给{_girl.Name}");
        }

        public void GiveFlower()
        {
            Console.WriteLine($"送了99朵玫瑰花给{_girl.Name}");
        }

        public void GiveLolly()
        {
            Console.WriteLine($"送了一支棒棒糖给{_girl.Name}");
        }
    }
}
