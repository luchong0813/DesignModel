using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 抽象发布者
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Addach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
