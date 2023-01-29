using Microsoft.AspNetCore.Mvc.Testing;
using ThePhoneBook.Tests.Shared;

namespace ThePhoneBook.FrontendMvc.Tests
{
    [CollectionDefinition("BaseTest")]
    public class BaseTestCollection : ICollectionFixture<BaseTestFixture>, IClassFixture<WebApplicationFactory<ProgramWrapper>> { }
}
