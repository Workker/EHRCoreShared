using ProtoBuf;

namespace EHR.CoreShared.Entities
{
    [ProtoContract]
    public class State : ValueObject
    {
        [ProtoMember(6)]
        public virtual string Acronym { get; set; }
    }
}