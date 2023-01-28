﻿using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Moq;
using ThePhoneBook.FrontendMvc.Interfaces;

namespace ThePhoneBook.FrontendMvc.Tests.Fixtures
{
    public class BaseTestFixture
    {
        public IServiceProvider LocalServiceProvider { get; private set; }
        public Mock<IUnitFetchContacts> UnitFetchContactsMock { get; private set; }

        public HttpClient GenerateClient(WebApplicationFactory<Program> factory)
        {
            UnitFetchContactsMock = new Mock<IUnitFetchContacts>();

            var client = factory.WithWebHostBuilder(hostBuilder =>
            {
                hostBuilder.ConfigureServices(services =>
                {
                    services.Replace(new ServiceDescriptor(typeof(IUnitFetchContacts), UnitFetchContactsMock.Object));

                });
            }).CreateClient();

            IServiceScope serviceScope = factory.Services.CreateScope();
            LocalServiceProvider = serviceScope.ServiceProvider;

            return client;
        }

    }
}
