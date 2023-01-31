using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Models;
using ThePhoneBook.Data;
using ThePhoneBook.Data.Entities;
using ThePhoneBook.Data.Repositories;

namespace ThePhoneBook.Core.Units;

public class UnitFetchContacts : IUnitFetchContacts
{
    private readonly IMapperWrapper _mapper;
    private readonly IEfRepository<Contact> _contactsQueryRepository;

    public UnitFetchContacts(IRepositoryFactory repositoryFactory, IMapperWrapper mapper)
    {
        _contactsQueryRepository = repositoryFactory.GenerateRepositoryFor<Contact>();
        _mapper = mapper;
    }

    public async Task<IEnumerable<ContactModel>> Execute()
    {
        var entities = await _contactsQueryRepository.Read(10); //TODO: implement paging instead of hardcoded
        var contacts = _mapper.Map<Contact, ContactModel>(entities);

        return contacts;
    }
}