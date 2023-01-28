using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc.Interfaces;

public interface IUnitFetchContacts : ICqrsQuery<IEnumerable<ContactDto>>
{
}