using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Core.Interfaces;

public interface IUnitFetchContacts : ICqrsQuery<IEnumerable<ContactModel>>
{
}