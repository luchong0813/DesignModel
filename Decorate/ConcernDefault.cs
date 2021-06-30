using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class ConcernDefault:Person
    {
        public override void Show()
        {
            Console.WriteLine("裤衩");
        }
    }
}
