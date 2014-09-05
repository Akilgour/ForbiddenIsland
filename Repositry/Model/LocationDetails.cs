using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
    public class LocationDetails : ILocationDetails
    {

        public LocationDetails(int Id, string Name, Repositry.Repository.Enums.PlayerColours StartingTileForPlayer, Repository.Enums.Treasures CanHaveTreasures)
        {
            this.Id = Id;
            this.Name = Name;
            this.StartingTileForPlayer = StartingTileForPlayer;
            this.CanHaveTreasures = CanHaveTreasures;
        }


        public LocationDetails(int Id, string Name)
            : this(Id, Name, Repositry.Repository.Enums.PlayerColours.None, Repository.Enums.Treasures.None)
        { }


        public int Id { get; set; }
        public string Name { get; set; }
        public Repositry.Repository.Enums.PlayerColours StartingTileForPlayer { get; set; }
        public Repository.Enums.Treasures CanHaveTreasures { get; set; }
    }
}
