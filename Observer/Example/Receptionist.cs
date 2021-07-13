using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Observer.Program;

namespace Observer.Example
{
    /// <summary>
    /// 前台小姐姐(发布者/通知者)
    /// </summary>
    public class Receptionist : ISubject
    {
        public event MyDelegate Update;

        private string action;

        public string SubjectState { get { return action; } set { action = value; } }

        public void Notify()
        {
            Update?.Invoke();
        }
    }
}
