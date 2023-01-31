using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ThePhoneBook.Shared.Interfaces;

namespace ThePhoneBook.Data.Repositories
{
    public class RepositoryFactory<TContext> : IRepositoryFactory where TContext : DbContext
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly TContext _dbContext;

        public RepositoryFactory(IServiceProvider serviceProvider, TContext dbContext)
        {
            _serviceProvider = serviceProvider;
            _dbContext = dbContext;
        }

        public T Generate<T>() where T : ICqrsAction
        {
            return ActivatorUtilities.CreateInstance<T>(_serviceProvider, _dbContext);
        }

        public IEfRepository<T> GenerateRepositoryFor<T>() where T : class
        {
            return ActivatorUtilities.CreateInstance<EfRepository<T>>(_serviceProvider, _dbContext);
        }
    }
}