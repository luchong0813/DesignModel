using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 房屋建造者
    /// </summary>
    public interface IHouseBuilder
    {
        void buildWall();
        void buildRoof();
        void buildWindow();
        void buildDoor();
        void buildResult();
    }
}
