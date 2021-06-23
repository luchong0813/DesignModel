using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashContext
    {
        CashSuper cashSuper = null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "打8折":
                    cashSuper = new CashRebate(0.8);
                    break;
                case "满300返100":
                    cashSuper = new CashReturn(300, 100);
                    break;
                default:
                    cashSuper = new CashNormal();
                    break;
            }
        }

        /// <summary>
        /// 获取计算价格结果
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return cashSuper.acceptCash(money);
        }
    }
}
