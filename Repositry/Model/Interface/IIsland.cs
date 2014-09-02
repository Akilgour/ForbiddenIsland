using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
    public interface IIsland
    {
        DataTable IslandBoard { get; set; }
    }
}
