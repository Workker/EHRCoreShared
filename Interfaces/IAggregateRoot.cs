namespace EHR.CoreShared.Interfaces
{
    public interface IAggregateRoot<T>
    {
        T Id { get; set; }
    }
}