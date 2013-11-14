namespace EHR.CoreShared.Entities
{
    public class Database : ValueObject
    {
        public virtual string Host { get; set; }
        public virtual string Service { get; set; }
        public virtual string User { get; set; }
        public virtual string Password { get; set; }
    }
}