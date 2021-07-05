using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        private WorkExperince workExperince;

        public Resume()
        {
            workExperince = new WorkExperince();
        }

        private Resume(WorkExperince work)
        {
            //提供Clone方法调用的私有构造函数，以便克隆"工作经历"的数据
            workExperince = (WorkExperince)work.Clone();
        }

        public void SetWorkExperince(string workDate, string workCompany)
        {
            workExperince.WorkDate = workDate;
            workExperince.Company = workCompany;
        }


        public void Display()
        {
            Console.WriteLine($"个人信息：\r\n{Name}\t{Sex}\t{Age}");
            Console.WriteLine($"工作经历：\r\n{workExperince.WorkDate}\t{workExperince.Company}\t");
        }

        public object Clone()
        {
            //return MemberwiseClone();
            Resume resume = new Resume(workExperince);
            resume.Name = Name;
            resume.Age = Age;
            resume.Sex = Sex;
            return resume;

        }
    }
}
