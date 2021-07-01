using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }
}
