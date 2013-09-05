
using ProtoBuf;

namespace EHR.CoreShared
{
    [ProtoContract]
    public class State : ValueObject
    {
        [ProtoMember(6)]
        public virtual string Acronym { get; set; }
    }
}