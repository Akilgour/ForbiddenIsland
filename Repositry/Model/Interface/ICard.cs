using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
   public interface ICard
    {
       int Id { get; set; }
       string Tite { get; set; }
    }
}
