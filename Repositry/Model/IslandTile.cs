using Repositry.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
    public class IslandTile : IIslandTile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Repository.Enums.TileState SubmergedState { get; set; }
        public Repository.Enums.PlayerColours StartingTileForPlayer { get; set; }
        public Repository.Enums.Treasures CanHaveTreasures { get; set; }
        public bool hasTreasures { get; set; }
    }
}
