using EHR.CoreShared.Interfaces;

namespace EHR.CoreShared.Entities
{
    public abstract class ValueObject : IAggregateRoot<short>
    {
        public virtual short Id { get; set; }
        public virtual string Description { get; set; }
    }
}