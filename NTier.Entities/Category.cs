using NTier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Entities
{
    
   public class Category : CoreEntitiy
    {


        public string  CategoryName { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }


    }
}
