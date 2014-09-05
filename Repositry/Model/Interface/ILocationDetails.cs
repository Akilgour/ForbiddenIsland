using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
    public interface ILocationDetails
    {
        int Id { get; set; }
        string Name { get; set; }
        Repositry.Repository.Enums.PlayerColours StartingTileForPlayer { get; set; }
        Repositry.Repository.Enums.Treasures CanHaveTreasures { get; set; }
    }
}
