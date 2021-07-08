using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Tower : IHouseBuilder
    {
        public void buildDoor()
        {
            Console.WriteLine("安装城堡大门");
        }

        public void buildResult()
        {
            Console.WriteLine("城堡");
        }

        public void buildRoof()
        {
            Console.WriteLine("城堡塔尖");
        }

        public void buildWall()
        {
            Console.WriteLine("城堡墙壁");
        }

        public void buildWindow()
        {
            Console.WriteLine("城堡窗户");
        }
    }
}
