using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 具体建造者
    /// </summary>
    public class House : IHouseBuilder
    {
        public void buildDoor()
        {
            Console.WriteLine("装房门");
        }

        public void buildResult()
        {
            Console.WriteLine("普通木屋");
        }

        public void buildRoof()
        {
            Console.WriteLine("盖房顶");
        }

        public void buildWall()
        {
            Console.WriteLine("盖墙壁");
        }

        public void buildWindow()
        {
            Console.WriteLine("安装窗户");
        }
    }
}
