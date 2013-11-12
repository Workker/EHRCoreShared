using ProtoBuf;

namespace EHR.CoreShared.Entities
{
    [ProtoContract]
    public class Hospital : ValueObject
    {
        [ProtoMember(3)]
        public virtual string Name { get; set; }

        [ProtoMember(4)]
        public virtual string URLImage { get; set; }

        [ProtoMember(5)]
        public virtual State State { get; set; }

        [ProtoMember(6)]
        public virtual DbEnum Key { get; set; }
    }
}