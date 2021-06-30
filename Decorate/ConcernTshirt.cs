using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorate
{
    public class ConcernTshirt : Decorator
    {
        public ConcernTshirt(Person person) : base(person)
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("T恤");
            Necktie();
        }

        private void Necktie()
        {
            Console.WriteLine("领带");
        }
    }
}
