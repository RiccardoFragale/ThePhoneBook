using ThePhoneBook.FrontendMvc.Interfaces;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc.Features;

public interface IFetchContactsQueryFeature : ICqrsQuery<IEnumerable<ContactDto>>
{

}