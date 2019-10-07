using ApiNetCore_Data.Context;
using ApiNetCore_Data.Repository;
using ApiNetCore_Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ApiNetCore_CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesReposiotry(IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IUserRepository, UserRepository>();

            serviceCollection.AddDbContext<DotNetContext>();

        }
    }
}
