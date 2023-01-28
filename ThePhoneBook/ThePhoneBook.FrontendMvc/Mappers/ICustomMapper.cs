namespace ThePhoneBook.FrontendMvc.Mappers;

public interface ICustomMapper<TSource, TDest>
{
    TDest Map(TSource source);
    IEnumerable<TDest> Map(IEnumerable<TSource> source);
    TSource MapReverse(TDest source);
    IEnumerable<TSource> MapReverse(IEnumerable<TDest> source);
}