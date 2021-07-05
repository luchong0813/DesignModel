using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 工作经历
    /// </summary>
    public class WorkExperince : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
