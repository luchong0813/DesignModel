using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 具体发布者
    /// </summary>
    public class ConcertSubject : Subject
    {
        private string _state;
        /// <summary>
        /// 具体被观察者状态
        /// </summary>
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}
