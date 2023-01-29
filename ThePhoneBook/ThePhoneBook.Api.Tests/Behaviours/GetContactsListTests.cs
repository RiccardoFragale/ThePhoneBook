using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
using ThePhoneBook.Api.Models;
using ThePhoneBook.Tests.Shared;

namespace ThePhoneBook.Api.Tests.Behaviours
{
    [Collection("BaseTest")]
    public class GetContactsListTests
    {
        private readonly BaseTestFixture _fixture;
        private readonly HttpClient _client;

        public GetContactsListTests(WebApplicationFactory<ProgramWrapper> factory, BaseTestFixture fixture)
        {
            _fixture = fixture;
            _client = _fixture.GenerateClient(factory);
        }

        [Fact]
        public async Task When_GetIsCalled_Should_ReturnContactsList()
        {
            // Act
            var response = await _client.GetAsync($"/PhoneBook");

            var results = await response.Content.ReadFromJsonAsync<IEnumerable<ContactsDto>>();

            //Assert
            results.Should().NotBeNullOrEmpty();
            results.Should().HaveCount(2);
        }
    }
}