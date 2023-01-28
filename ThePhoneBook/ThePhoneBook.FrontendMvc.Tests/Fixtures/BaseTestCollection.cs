using Microsoft.AspNetCore.Mvc.Testing;


namespace ThePhoneBook.FrontendMvc.Tests.Fixtures
{
    [CollectionDefinition("BaseTest")]
    public class BaseTestCollection : ICollectionFixture<BaseTestFixture>, IClassFixture<WebApplicationFactory<Program>> { }
}
