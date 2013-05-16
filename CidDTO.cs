using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.CoreShared
{
    public class CidDTO
    {
        public virtual short Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Code { get; set; }
    }
}
