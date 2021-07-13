using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}
