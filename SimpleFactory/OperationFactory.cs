using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string operation)
        {
            Operation oper = null;
            switch (operation)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                default:
                    oper = new OperationAdd();
                    break;
            }
            return oper;
        }
    }
}
