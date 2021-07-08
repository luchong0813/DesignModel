using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /**
    * 模式：建造者模式
    * 时间：2021-07-08
    * blog：https://www.cnblogs.com/chonglu/
    */
    class Program
    {
        /**
         * 场景：盖房子，房子都有房顶、四面墙壁、窗户和门，可以使用不同的材料，例如，第一个建造者使用木头和玻璃，第二个建造者使用石头和钢铁
         * 在调用一组步骤后，第一个建造者得到的是一栋普通房屋，第二栋得到的是一栋城堡
         */
        static void Main(string[] args)
        {
            HouseDirector houseDirector = new HouseDirector();

            Console.WriteLine("------------------盖一栋普通木屋------------------");
            IHouseBuilder houseBuilder1 = new House();
            houseDirector.Construct(houseBuilder1);
            houseBuilder1.buildResult();

            Console.WriteLine("------------------盖一栋城堡------------------");
            IHouseBuilder houseBuilder2 = new Tower();
            houseDirector.Construct(houseBuilder2);
            houseBuilder2.buildResult();

            Console.WriteLine("Press Any Key to end!");
            Console.ReadKey();
        }
    }
}
