using Repositry.Factory.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Factory
{
    public class FloodDeckFactory : IFloodDeckFactory
    {
      
        public  FloodDeck Create(object LocationDetails)
        {
            if (!(LocationDetails is List<LocationDetails>))
            {
                throw new ArgumentException("LocationDetails must be a list of LocationDetails");
            }
         
            var locationDetails = (List<LocationDetails>)LocationDetails;
            //This radomises the list, so it shuffels the deck
            locationDetails = locationDetails.OrderBy(emp => Guid.NewGuid()).ToList();

            var floodDeck = new FloodDeck();
            floodDeck.CardDrawPile = new List<CardFlood>();
            foreach (var location in locationDetails)
            {
                floodDeck.CardDrawPile.Add(new CardFlood() { IslandTileid = location.Id, IslandTile = location.Name });
            }

            return floodDeck;
        }
    }
}
