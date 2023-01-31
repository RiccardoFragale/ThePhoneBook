using Microsoft.AspNetCore.Mvc;
using ThePhoneBook.Api.Models;
using ThePhoneBook.Core.Features;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Models;

namespace ThePhoneBook.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneBookController : ControllerBase
    {
        private readonly IFetchContactsActionFeature _fetchContactsFeature;
        private readonly IMapperWrapper _mapper;

        public PhoneBookController(IFetchContactsActionFeature fetchContactsFeature, IMapperWrapper mapper)
        {
            _fetchContactsFeature = fetchContactsFeature;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ContactDto>> Get()
        {
            var model = await _fetchContactsFeature.Execute();

            return _mapper.Map<ContactModel, ContactDto>(model);
        }
    }
}