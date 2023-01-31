using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ThePhoneBook.Core.Features;
using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Mocks;
using ThePhoneBook.Core.Units;
using ThePhoneBook.Data;
using ThePhoneBook.Data.Repositories;

namespace ThePhoneBook.Core
{
    public static class SharedLib
    {
        public static void CommonConfigs(IServiceCollection services, bool useMocks)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = ":memory:" };
            var connection = new SqliteConnection(connectionStringBuilder.ToString());
            connection.Open();

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connection));

            services.AddTransient<IFetchContactsActionFeature, FetchContactsActionFeature>();
            services.AddTransient<IMapperWrapper, AutoMapperExternal>();
            services.AddTransient<IRepositoryFactory, RepositoryFactory<AppDbContext>>();

            if (useMocks)
            {
                services.AddTransient<IUnitFetchContacts, UnitFetchContactsMock>();
            }
            else
            {
                services.AddTransient<IUnitFetchContacts, UnitFetchContacts>();
            }
        }
    }
}
