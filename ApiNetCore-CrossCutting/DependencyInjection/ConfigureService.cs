using ApiNetCore_Domain.Interfaces.Services;
using ApiNetCore_Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApiNetCore_CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IUserService, UserService>();
          //  serviceCollection.AddTransient<ILoginService, LoginService>();

        }
    }
}
