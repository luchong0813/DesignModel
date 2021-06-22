using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Operation
    {
        public double NumA { get; set; }

        public double NumB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
