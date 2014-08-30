using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
    interface IIslandTile
    {
        int id { get; set; }
        string name { get; set; }
        bool isFlooded { get; set; }
        Repositry.Repository.Enums.PlayerColours startingTileForPlayer { get; set; }
        Repositry.Repository.Enums.Treasures canHaveTreasures { get; set; }
        bool hasTreasures { get; set; }
    }
}
