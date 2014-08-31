using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
   public  class Enums
    {
       public enum PlayerColours
       {
           Red,
           Green,
           Yellow,
           Purple,
           Blue,
           Silver,
           None
       }

       public enum Treasures
       {
           TheEarthStone,
           TheStatueOfTheWind,
           TheCrystalOfFire,
           TheOceansChalice,
           None
       }

       public enum TileState
       {
           Normal,
           Flodded,
           Gone
       }
    }
}
