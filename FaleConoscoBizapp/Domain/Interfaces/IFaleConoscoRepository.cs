using FaleConoscoBizapp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaleConoscoBizapp.Models.Interfaces
{
   public interface IFaleConoscoRepository
   {
        void Insert(FaleConoscoModel model);
   }
}
