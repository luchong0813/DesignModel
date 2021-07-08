using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stock
{
    public class Stock3 : BaseStock
    {
        public override void Buy()
        {
            Console.WriteLine("买入股票3");
        }

        public override void Sell()
        {
            Console.WriteLine("卖出股票3");
        }
    }
}
