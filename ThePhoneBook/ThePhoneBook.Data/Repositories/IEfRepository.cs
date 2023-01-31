namespace ThePhoneBook.Data.Repositories;

public interface IEfRepository<T>
{
    Task<List<T>> Read(int count);
}