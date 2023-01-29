using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Core.Features;

public interface IFetchContactsQueryFeature : ICqrsQuery<IEnumerable<ContactModel>>
{

}