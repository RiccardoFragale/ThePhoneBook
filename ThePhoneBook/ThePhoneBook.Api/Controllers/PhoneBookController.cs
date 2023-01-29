using Microsoft.AspNetCore.Mvc;
using ThePhoneBook.Core.Features;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Models;
using ContactDto = ThePhoneBook.Api.Models.ContactDto;

namespace ThePhoneBook.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneBookController : ControllerBase
    {
        private readonly IFetchContactsQueryFeature _fetchContactsFeature;
        private readonly ICustomMapper<ContactModel, ContactDto> _customMapper;

        public PhoneBookController(IFetchContactsQueryFeature fetchContactsFeature, ICustomMapper<ContactModel, ContactDto> customMapper)
        {
            _fetchContactsFeature = fetchContactsFeature;
            _customMapper = customMapper;
        }

        [HttpGet]
        public IEnumerable<ContactDto> Get()
        {
            var model = _fetchContactsFeature.Execute();

            return _customMapper.Map(model);
        }
    }
}