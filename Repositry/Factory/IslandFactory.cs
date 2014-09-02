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
        public IIsland Create()
        {

            return new Island();
        }
    }
}
