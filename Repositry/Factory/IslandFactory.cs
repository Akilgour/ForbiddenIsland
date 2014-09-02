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
        public IIsland Create(object FloodCards)
        {
            if  (!( FloodCards is List<CardFlood>))
            {
                throw new ArgumentException("FloodCards must be a list of CardFloods");
            }

            var floodCards = (List<CardFlood>)FloodCards;

            if (floodCards.Count != 24)
            {
                throw new ArgumentException("There must be 24 cards passed into the Island Factory");
            }

            return new Island();
        }

      
    }
}
