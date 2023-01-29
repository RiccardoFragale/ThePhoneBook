namespace ThePhoneBook.Core.Mappers;

public class CustomMapper<TSource, TDest> : ICustomMapper<TSource, TDest>
{
    private readonly IMapperWrapper _mapper;

    public CustomMapper(IMapperWrapper mapper)
    {
        _mapper = mapper;
    }

    public TDest Map(TSource source)
    {
        return _mapper.Map<TSource, TDest>(source);
    }

    public IEnumerable<TDest> Map(IEnumerable<TSource> source)
    {
        return source.Select(_mapper.Map<TSource, TDest>);
    }

    public TSource MapReverse(TDest source)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TSource> MapReverse(IEnumerable<TDest> source)
    {
        throw new NotImplementedException();
    }
}
