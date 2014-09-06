using Repositry.Factory.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Factory.Interface
{
    public interface IIslandTileFactory
    {
        IslandTile Create(object LocationDetails);
    }
}
