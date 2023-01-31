using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Models;
using ThePhoneBook.Shared.Interfaces;

namespace ThePhoneBook.Core.Features;

public interface IFetchContactsActionFeature : ICqrsAction<IEnumerable<ContactModel>>
{

}