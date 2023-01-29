using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Moq;
using ThePhoneBook.Core.Interfaces;

namespace ThePhoneBook.Tests.Shared
{
    public class BaseTestFixture
    {
        public IServiceProvider LocalServiceProvider { get; private set; }
        //public Mock<IUnitFetchContacts> UnitFetchContactsMock { get; private set; }

        public HttpClient GenerateClient<T>(WebApplicationFactory<T> factory) where T : class
        {
            //UnitFetchContactsMock = new Mock<IUnitFetchContacts>();

            var client = factory.WithWebHostBuilder(hostBuilder =>
            {
                //hostBuilder.ConfigureServices(services =>
                //{
                //    services.Replace(new ServiceDescriptor(typeof(IUnitFetchContacts), UnitFetchContactsMock.Object));

                //});
            }).CreateClient();

            IServiceScope serviceScope = factory.Services.CreateScope();
            LocalServiceProvider = serviceScope.ServiceProvider;

            return client;
        }

    }
}
