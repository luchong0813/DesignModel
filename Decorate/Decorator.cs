using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class Decorator : Person
    {
        private readonly Person _person;
        public Decorator(Person person)
        {
            _person = person;
        }

        public override void Show()
        {
            if (_person != null)
            {
                _person.Show();
            }
        }
    }
}
