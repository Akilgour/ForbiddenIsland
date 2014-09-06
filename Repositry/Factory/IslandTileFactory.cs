using Repositry.Factory.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Factory
{
    public class IslandTileFactory : IIslandTileFactory
    {

       public  IslandTile  Create(object LocationDetails)
        {
            if (!(LocationDetails is  LocationDetails ))
            {
                throw new ArgumentException("LocationDetails must be of type LocationDetails");
            }
            var locationDetails = (LocationDetails)LocationDetails;
            IslandTile islandTile = new IslandTile();
            islandTile.Id = locationDetails.Id;
            islandTile.Name = locationDetails.Name;
            islandTile.StartingTileForPlayer = locationDetails.StartingTileForPlayer;
            islandTile.CanHaveTreasures = locationDetails.CanHaveTreasures;
            return islandTile;
        }
    }
}
