using Facade.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Stock;

namespace Facade
{
    /// <summary>
    /// 基金1
    /// </summary>
    public class Fund
    {
        private Stock1 stock1;
        private Stock2 stock2;
        private Stock3 stock3;

        public Fund()
        {
            stock1 = new Stock1();
            stock2 = new Stock2();
            stock3 = new Stock3();
        }

        public void BuyFund()
        {
            stock1.Buy();
            stock2.Buy();
            stock3.Buy();
        }

        public void SellFund()
        {
            stock1.Sell();
            stock2.Sell();
            stock3.Sell();
        }
    }
}
