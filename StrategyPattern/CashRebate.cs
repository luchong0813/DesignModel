using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 折扣收费策略
    /// </summary>
    public class CashRebate : CashSuper
    {
        double moneyRebate = 1d;

        public CashRebate(double rebate)
        {
            moneyRebate = rebate;
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
