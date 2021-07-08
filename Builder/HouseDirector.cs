using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指挥者（工头/建筑工程师/建筑设计工程师...）
    /// </summary>
    public class HouseDirector
    {

        public void Construct(IHouseBuilder houseBuilder)
        {
            houseBuilder.buildWall();
            houseBuilder.buildWall();
            houseBuilder.buildWindow();
            houseBuilder.buildDoor();
        }
    }
}
