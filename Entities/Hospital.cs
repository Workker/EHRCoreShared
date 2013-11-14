namespace EHR.CoreShared.Entities
{

    public class Hospital : ValueObject
    {
        public virtual string Name { get; set; }
        public virtual string URLImage { get; set; }
        public virtual State State { get; set; }
        public virtual string Key { get; set; }
        public virtual Database Database { get; set; }
    }
}