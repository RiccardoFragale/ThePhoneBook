namespace ThePhoneBook.Core.Interfaces;

public interface ICqrsQuery<TOut>
{
    TOut Execute();
}