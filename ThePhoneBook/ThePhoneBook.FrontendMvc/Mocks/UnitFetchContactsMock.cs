using ThePhoneBook.FrontendMvc.Interfaces;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc.Mocks;

public class UnitFetchContactsMock : IUnitFetchContacts
{
    private IEnumerable<ContactDto> _contacts = new List<ContactDto>
    {
        new ContactDto
        {
            Name = "test1",
            PhoneNumber = "01010101010"
        },
        new ContactDto
        {
            Name = "test2",
            PhoneNumber = "01010101011"
        }
    };

    public IEnumerable<ContactDto> Execute()
    {
        return _contacts;
    }
}