using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
    public class FloodDeck : IFloodDeck
    {
        public List<CardFlood> CardDrawPile { get; set; }
    }
}
