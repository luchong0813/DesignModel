using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    /**
    * 模式：装饰模式
    * 时间：2021-06-30
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "傲慢与偏见" };

            Console.WriteLine("----------------穿搭1----------------");
            var simple1 = new ConcernDefault();
            ConcernPoloShirt concernPoloShirt = new ConcernPoloShirt(simple1);
            ConcernBlouse concernBlouse = new ConcernBlouse(concernPoloShirt);
            person.Show();
            concernBlouse.Show();


            Console.WriteLine("----------------穿搭2----------------");
            var simple2 = new ConcernDefault();
            ConcernTshirt concernTshirt = new ConcernTshirt(simple2);
            ConcernBlouse concernBlouse1 = new ConcernBlouse(concernTshirt);
            ConcernPoloShirt concernPoloShirt1 = new ConcernPoloShirt(concernBlouse1);
            person.Show();
            concernPoloShirt1.Show();
            //ConcernDefault-->ConcernTshirt-->ConcernBlouse-->ConcernPoloShirt

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
