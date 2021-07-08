using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stock
{
    public abstract class BaseStock
    {
        public abstract void Sell();
        public abstract void Buy();
    }
}
