using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 返利策略
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double _conditionMoney;
        private double _returnMoney;
        public CashReturn(double conditionMoney, double returnMoney)
        {
            _conditionMoney = Convert.ToDouble(conditionMoney);
            _returnMoney = Convert.ToDouble(returnMoney);
        }

        public override double acceptCash(double money)
        {
            var result = money;
            if (money >= _conditionMoney)
            {
                result = money - Math.Floor(money / _conditionMoney) * _returnMoney;
            }
            return result;
        }
    }
}
