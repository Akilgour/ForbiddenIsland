﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
    public interface ICardTreasure : ICardPlayerHandCard
    {
        Repositry.Repository.Enums.Treasures forTreasures { get; set; }
    }
}
