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
    public class ConcertObserver : Observer
    {
        private string _name;
        private string observerState;

        public ConcertObserver(ConcertSubject concertSubject, string name)
        {
            ConcertSubject = concertSubject;
            _name = name;
        }

        public override void Update()
        {
            observerState = ConcertSubject.State;
            Console.WriteLine($"观察者{_name}的最新状态是{observerState}");
        }

        private ConcertSubject _concertSubject;

        public ConcertSubject ConcertSubject
        {
            get { return _concertSubject; }
            set { _concertSubject = value; }
        }

    }
}
