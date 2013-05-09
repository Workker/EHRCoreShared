using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.CoreShared
{
    public class RecordDTO
    {
        public virtual string Code { get; set; }
        public virtual DbEnum Hospital { get; set; }
    }
}
