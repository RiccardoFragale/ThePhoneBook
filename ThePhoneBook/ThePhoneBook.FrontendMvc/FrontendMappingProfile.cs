using AutoMapper;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc;

public class FrontendMappingProfile : Profile
{
    public FrontendMappingProfile()
    {
        CreateMap<ContactDto, VmContact>().ReverseMap();
    }
}