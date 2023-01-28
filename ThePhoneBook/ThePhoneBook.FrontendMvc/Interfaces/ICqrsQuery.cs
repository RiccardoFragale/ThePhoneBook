namespace ThePhoneBook.FrontendMvc.Interfaces;

public interface ICqrsQuery<TOut>
{
    TOut Execute();
}