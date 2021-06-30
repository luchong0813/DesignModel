using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class Person
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"会穿搭的{Name}");
        }
    }
}
