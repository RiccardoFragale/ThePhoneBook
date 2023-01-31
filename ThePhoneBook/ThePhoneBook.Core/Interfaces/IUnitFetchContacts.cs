using ThePhoneBook.Core.Models;
using ThePhoneBook.Shared.Interfaces;

namespace ThePhoneBook.Core.Interfaces;

public interface IUnitFetchContacts : ICqrsAction<IEnumerable<ContactModel>>
{
}