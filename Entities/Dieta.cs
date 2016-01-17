using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.CoreShared.Entities
{
    public class Dieta : ValueObject
    {
        public virtual string ActivePrinciple { get; set; }
    }
}
