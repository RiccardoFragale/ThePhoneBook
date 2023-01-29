using AutoMapper;
using ThePhoneBook.Core.Models;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc;

public class FrontendMappingProfile : Profile
{
    public FrontendMappingProfile()
    {
        CreateMap<ContactModel, VmContact>().ReverseMap();
    }
}