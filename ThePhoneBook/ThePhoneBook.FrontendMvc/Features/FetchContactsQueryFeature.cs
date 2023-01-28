using ThePhoneBook.FrontendMvc.Interfaces;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc.Features
{
    public class FetchContactsQueryFeature : IFetchContactsQueryFeature
    {
        private readonly IUnitFetchContacts _unitFetchContacts;

        public FetchContactsQueryFeature(IUnitFetchContacts unitFetchContacts)
        {
            _unitFetchContacts = unitFetchContacts;
        }

        public IEnumerable<ContactDto> Execute()
        {
            return _unitFetchContacts.Execute();
        }
    }
}
