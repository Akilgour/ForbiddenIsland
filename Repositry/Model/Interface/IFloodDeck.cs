using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
   public interface IFloodDeck
    {
        List<CardFlood> CardDrawPile { get; set; }
    }
}
