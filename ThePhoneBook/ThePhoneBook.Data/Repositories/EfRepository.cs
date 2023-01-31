using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ThePhoneBook.Data.Repositories
{
    public class EfRepository<T> : IEfRepository<T> where T : class
    {
        private readonly AppDbContext _appContext;

        public EfRepository(AppDbContext appContext)
        {
            appContext.Database.EnsureCreated();

            _appContext = appContext;
        }

        public async Task<List<T>> Read(int count)
        {
            return await _appContext.Set<T>().Take(count).ToListAsync();
        }
    }
}
