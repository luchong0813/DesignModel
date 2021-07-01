using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 代理类（类比为小华）
    /// 小明请求小华代替他向小红送礼物
    /// </summary>
    public class Proxy : IGaveGift
    {
        private Purist xiaoming;
        public Proxy(Girl girl)
        {
            xiaoming = new Purist(girl);
        }

        public void GiveChocolate()
        {
            xiaoming.GiveChocolate();
        }

        public void GiveFlower()
        {
            xiaoming.GiveFlower();
        }

        public void GiveLolly()
        {
            xiaoming.GiveLolly();
        }
    }
}
