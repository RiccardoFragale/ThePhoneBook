using AutoMapper;
using ThePhoneBook.Api.Models;
using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Api;

public class ApiMappingProfile : Profile
{
    public ApiMappingProfile()
    {
        CreateMap<ContactModel, ContactDto>().ReverseMap();
    }
}