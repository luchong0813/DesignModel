using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Example
{
    public class EmployeeA
    {
        private string _name;
        private ISubject _subject;

        public EmployeeA(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseTV()
        {
            Console.WriteLine($"{_subject.SubjectState},{_name}，关掉电视剧，继续写代码");
        }
    }
}
