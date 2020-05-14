using basicBackend.Application.Interfaces;

namespace basicBackend.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IContactRepository contactRepository)
        {
            Contacts = contactRepository;
        }
        public IContactRepository Contacts { get; }
    }
}