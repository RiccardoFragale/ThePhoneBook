using AutoMapper;

namespace ThePhoneBook.Core.Mappers;

public interface IMapperWrapper
{
    TDest Map<TSource, TDest>(TSource source);
}

public class Mapper : IMapperWrapper
{
    private readonly IMapper _mapper;

    public Mapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public TDest Map<TSource, TDest>(TSource source)
    {
        return _mapper.Map<TSource, TDest>(source);
    }
}