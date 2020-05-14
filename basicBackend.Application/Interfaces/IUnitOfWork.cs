namespace basicBackend.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IContactRepository Contacts { get; }
    }
}