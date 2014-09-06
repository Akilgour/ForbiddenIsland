using Repositry.Factory.Interface;
using Repositry.Model;
using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Factory
{
    public class IslandFactory : IIslandFactory
    {
        public IIsland Create(object LocationDetails)
        {
            if (!(LocationDetails is List<LocationDetails>))
            {
                throw new ArgumentException("FloodCards must be a list of PlaceNameId");
            }

            var locationDetails = (List<LocationDetails>)LocationDetails;

            if (locationDetails.Count != 24)
            {
                throw new ArgumentException("There must be 24 cards passed into the Island Factory");
            }

            var island = new Island();
            island.IslandBoard = new List<IslandTile>();
            var islandTileFactory = new IslandTileFactory();
            foreach (var location in locationDetails)
            {
                //island.IslandBoard.Add(new IslandTile() { Id = location.Id, Name = location.Name, StartingTileForPlayer = location.StartingTileForPlayer, CanHaveTreasures = location.CanHaveTreasures });
                island.IslandBoard.Add(  islandTileFactory.Create(location)  );

            }

            return island;
        }
    }
}
