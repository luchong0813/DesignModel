using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class ConcernPoloShirt : Decorator
    {
        public ConcernPoloShirt(Person person) : base(person)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Polo衫");
        }
    }
}
