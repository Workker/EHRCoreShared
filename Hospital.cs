
using ProtoBuf;

namespace EHR.CoreShared
{
    [ProtoContract]
    public class Hospital : ValueObject
    {
        [ProtoMember(3)]
        public virtual string Name { get; set; }
        [ProtoMember(4)]
        public virtual string URLImage { get; set; }
    }
}
