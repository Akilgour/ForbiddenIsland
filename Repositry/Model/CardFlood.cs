using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
   public class CardFlood : ICardFlood
    {
        public int IslandTileid { get; set; }
        public string IslandTile { get; set; }
    }
}
