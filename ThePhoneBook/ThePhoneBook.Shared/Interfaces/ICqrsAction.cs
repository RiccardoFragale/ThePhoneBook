namespace ThePhoneBook.Shared.Interfaces;

public interface ICqrsAction<TOut> : ICqrsAction
{
    Task<TOut> Execute();
}

public interface ICqrsAction
{

};