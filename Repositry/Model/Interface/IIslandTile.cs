using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Factory.Interface
{
    public interface IIslandTile
    {
        int Id { get; set; }
        string Name { get; set; }
        Repositry.Repository.Enums.TileState SubmergedState { get; set; }
        Repositry.Repository.Enums.PlayerColours StartingTileForPlayer { get; set; }
        Repositry.Repository.Enums.Treasures CanHaveTreasures { get; set; }
        bool hasTreasures { get; set; }
    }
}
