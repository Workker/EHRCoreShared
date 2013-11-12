using EHR.CoreShared.Interfaces;
using ProtoBuf;
using System;

namespace EHR.CoreShared.Entities
{
    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public class Treatment : ITreatment
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public DateTime EntryDate { get; set; }

        [ProtoMember(3)]
        public DateTime CheckOutDate { get; set; }

        [ProtoMember(4)]
        public virtual Hospital Hospital { get; set; }
    }
}
