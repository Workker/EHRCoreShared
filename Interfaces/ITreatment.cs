using ProtoBuf;
using System;

namespace EHR.CoreShared.Interfaces
{
    [ProtoContract(SkipConstructor = true)]
    public interface ITreatment
    {
        [ProtoMember(1)]
        string Id { get; set; }
        [ProtoMember(2)]
        DateTime EntryDate { get; set; }
        [ProtoMember(3)]
        DateTime CheckOutDate { get; set; }

        [ProtoMember(4)]
        DbEnum Hospital { get; set; }
    }
}
