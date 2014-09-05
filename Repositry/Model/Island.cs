using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
    public class Island : IIsland
    {
       public List<IslandTile> IslandBoard { get; set; }
    }
}
