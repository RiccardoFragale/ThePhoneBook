using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ThePhoneBook.Core.Features;
using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Mocks;

namespace ThePhoneBook.Core
{
    public static class SharedLib
    {
        public static void CommonConfigs(IServiceCollection services)
        {
            services.AddTransient<IFetchContactsQueryFeature, FetchContactsQueryFeature>();
            services.AddTransient<IUnitFetchContacts, UnitFetchContactsMock>();
            services.AddTransient<IMapperWrapper, AutoMapperExternal>();
            services.AddTransient(typeof(ICustomMapper<,>), typeof(CustomMapper<,>));
        }
    }
}
