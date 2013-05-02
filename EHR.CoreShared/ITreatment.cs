using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace EHR.CoreShared
{
    [ProtoContract(SkipConstructor = true)]
    public interface ITreatmentDTO
    {
        [ProtoMember(1)]
        string Id { get; set; }
        [ProtoMember(2)]
        DateTime EntryDate { get; set; }
        [ProtoMember(3)]
        DateTime CheckOutDate { get; set; }
    }
}
