using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Listener.Observer
{
    [Flags]
    public enum EventEnum
    {
        [Description("状态1")]
        Status1=1,
        [Description("状态2")]
        Status2 =2,
        [Description("状态3")]
        Status3 =3
    }
}
