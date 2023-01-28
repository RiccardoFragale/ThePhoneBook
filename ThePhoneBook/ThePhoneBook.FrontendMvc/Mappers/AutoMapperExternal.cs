using AutoMapper;

namespace ThePhoneBook.FrontendMvc.Mappers;

public class AutoMapperExternal : IMapperWrapper
{
    private readonly IMapper _mapper;

    public AutoMapperExternal(IMapper mapper)
    {
        _mapper = mapper;
    }

    public TDest Map<TSource, TDest>(TSource source)
    {
        return _mapper.Map<TSource, TDest>(source);
    }
}