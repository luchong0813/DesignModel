using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class ConcernBlouse : Decorator
    {
        public ConcernBlouse(Person person) : base(person)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("衬衫");
        }
    }
}
