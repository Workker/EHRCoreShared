using EHR.CoreShared.Interfaces;
using ProtoBuf;

namespace EHR.CoreShared.Entities
{
    [ProtoContract]
    [ProtoInclude(5, typeof(Hospital))]
    public abstract class ValueObject : IAggregateRoot<short>
    {
        [ProtoMember(1)]
        public virtual short Id { get; set; }
        [ProtoMember(2)]
        public virtual string Description { get; set; }
    }
}