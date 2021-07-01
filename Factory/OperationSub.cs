using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }
}
