using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Core.Mocks;

public class UnitFetchContactsMock : IUnitFetchContacts
{
    private IEnumerable<ContactModel> _contacts = new List<ContactModel>
    {
        new ContactModel
        {
            Name = "test1",
            PhoneNumber = "01010101010"
        },
        new ContactModel
        {
            Name = "test2",
            PhoneNumber = "01010101011"
        }
    };

    public IEnumerable<ContactModel> Execute()
    {
        return _contacts;
    }
}