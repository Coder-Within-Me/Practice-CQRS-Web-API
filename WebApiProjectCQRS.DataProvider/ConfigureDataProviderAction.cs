using Microsoft.Extensions.DependencyInjection;
using WebApiProjectCQRS.DataProvider.Repository.Implementation;
using WebApiProjectCQRS.DataProvider.Repository.Interface;

namespace WebApiProjectCQRS.DataProvider
{
    public class ConfigureDataProviderAction
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddTransient<IGetAllEmployees, GetAllEmployeesReader>();
            services.AddTransient<IInsertEmployeeDetails, InsertEmployeeDetailsWriter>();
        }

    }
}