using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /// <summary>
    /// 做饭模板类（抽象父类）
    /// </summary>
    public abstract class DodishTemplate
    {
        public void dodish()
        {
            preparation();
            doing();
            carriedDishes();
        }

        public abstract void preparation();
        public abstract void doing();
        public abstract void carriedDishes();
    }
}
