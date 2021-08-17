using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Listener.Observer
{
    public delegate void EventHandler();

    /// <summary>
    /// 订阅管理器
    /// </summary>
    public static class SubscriberManager
    {
        private class Listener
        {
            /// <summary>
            /// 编号
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// 事件处理钩子
            /// </summary>
            public EventHandler Handler { get; set; }
        }

        /// <summary>
        /// 事件映射
        /// </summary>
        private static Dictionary<EventEnum, List<Listener>> events = new Dictionary<EventEnum, List<Listener>>();


        /// <summary>
        /// 注册监听器
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventEnum"></param>
        /// <param name="handler"></param>
        public static void Register(int id, EventEnum eventEnum, EventHandler handler)
        {
            if (!events.ContainsKey(eventEnum))
            {
                List<Listener> listeners = new List<Listener>();
                listeners.Add(new Listener() { Id = id, Handler = handler });
                events.Add(eventEnum, listeners);
            }
            else
            {
                List<Listener> listeners = events[eventEnum];
                listeners.Add(new Listener() { Id = id, Handler = handler });
            }
        }

        /// <summary>
        /// 取消监听器
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventEnum"></param>
        /// <param name="handler"></param>
        public static void Unregister(int id, EventEnum eventEnum, EventHandler handler)
        {
            if (events.ContainsKey(eventEnum))
            {
                List<Listener> listeners = events[eventEnum];
                for (int i = listeners.Count; i > 0; i--)
                {
                    Listener listener = listeners[i - 1];
                    if (listener.Id.Equals(id) && listener.Handler.GetType() == handler.GetType())
                    {
                        listeners.Remove(listener);
                    }
                }
            }

        }

        /// <summary>
        /// 广播一个事件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventEnum"></param>
        public static void Publish(int id, EventEnum eventEnum)
        {
            if (events.ContainsKey(eventEnum))
            {
                List<Listener> listeners = events[eventEnum];
                foreach (var item in listeners)
                {
                    if (item.Id.Equals(id))
                    {
                        item.Handler();
                    }
                }
            }
        }
    }
}
