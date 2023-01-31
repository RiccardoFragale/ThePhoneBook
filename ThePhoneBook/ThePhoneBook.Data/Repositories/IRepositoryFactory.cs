using ThePhoneBook.Shared.Interfaces;

namespace ThePhoneBook.Data.Repositories
{
    public interface IRepositoryFactory
    {
        T Generate<T>() where T : ICqrsAction;
        IEfRepository<T> GenerateRepositoryFor<T>() where T : class;
    }
}