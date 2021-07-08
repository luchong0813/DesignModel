using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /**
    * 模式：外观模式
    * 时间：2021-07-08
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        /**
         * 场景：小明最近入坑理财了，就去炒股票，由于是新手，对证券金融理财等都没有建立完善的体系，导致最后血亏。
         * 后来听朋友建议去买基金，基金是由众多支股票组合而成的，由专业的基金经理管理投资，相当于买了一揽子股票，
         * 最终小明只需要在合适的时机买入和卖出，而不用过多的去关心买啥股票，这里使用外观模式简单实现一下。
         */
        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.BuyFund();
            fund.SellFund();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
