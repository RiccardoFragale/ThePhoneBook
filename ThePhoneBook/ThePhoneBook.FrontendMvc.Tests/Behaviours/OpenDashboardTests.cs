using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using ThePhoneBook.FrontendMvc.Controllers;
using ThePhoneBook.FrontendMvc.Models;
using ThePhoneBook.FrontendMvc.Tests.Fixtures;

namespace ThePhoneBook.FrontendMvc.Tests.Behaviours
{
    [Collection("BaseTest")]
    public class OpenDashboardTests
    {
        private readonly BaseTestFixture _fixture;
        private readonly HttpClient _client;

        public OpenDashboardTests(WebApplicationFactory<Program> factory, BaseTestFixture fixture)
        {
            _fixture = fixture;
            _client = _fixture.GenerateClient(factory);
        }

        [Fact]
        public async Task When_DashboardIsLoaded_Should_ReturnSuccess()
        {
            // Act
            var response = await _client.GetAsync($"/PhoneBook/Index");

            response.EnsureSuccessStatusCode(); // Status Code 200-299
        }

        [Fact]
        public void When_DashboardIsLoaded_Should_ContainContacts()
        {
            //Arrange
            var controller = _fixture.LocalServiceProvider.GetRequiredService<PhoneBookController>();

            // Act
            var response = controller.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(response);
            var returnValue = Assert.IsType<VmDashboard>(viewResult.Model);

            returnValue.Contacts.FirstOrDefault().Should().BeOfType<VmContact>();
            returnValue.Contacts.Should().NotBeNullOrEmpty();
            returnValue.Contacts.Should().HaveCount(2);
        }
    }
}