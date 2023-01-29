using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Core.Features
{
    public class FetchContactsQueryFeature : IFetchContactsQueryFeature
    {
        private readonly IUnitFetchContacts _unitFetchContacts;

        public FetchContactsQueryFeature(IUnitFetchContacts unitFetchContacts)
        {
            _unitFetchContacts = unitFetchContacts;
        }

        public IEnumerable<ContactModel> Execute()
        {
            return _unitFetchContacts.Execute();
        }
    }
}
