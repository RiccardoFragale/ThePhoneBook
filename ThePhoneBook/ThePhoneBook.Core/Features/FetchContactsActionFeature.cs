using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Models;
using ThePhoneBook.Core.Units;
using ThePhoneBook.Data.Repositories;

namespace ThePhoneBook.Core.Features
{
    public class FetchContactsActionFeature : IFetchContactsActionFeature
    {
        private readonly IUnitFetchContacts _unitFetchContacts;

        public FetchContactsActionFeature(IUnitFetchContacts unitFetchContacts)
        {
            _unitFetchContacts = unitFetchContacts;
        }

        public Task<IEnumerable<ContactModel>> Execute()
        {
            return _unitFetchContacts.Execute();
        }
    }
}
