using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /// <summary>
    /// 酸辣土豆丝（子类）
    /// </summary>
    public class Potatoes : DodishTemplate
    {
        public override void carriedDishes()
        {
            Console.WriteLine("清洗土豆并切丝，准备少许辣椒丝");
        }

        public override void doing()
        {
            Console.WriteLine("起锅烧油，放入土豆丝，适时加入调味里奥、盐等佐料。倒入辣椒丝");
        }

        public override void preparation()
        {
            Console.WriteLine("等待片刻，盛碗装盘");
        }
    }
}
