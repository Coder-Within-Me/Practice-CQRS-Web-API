using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.Mapper;
using MediatR;

namespace WebApiProjectCQRS.Service
{
    public class ConfigureServicesAction
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllEmployeesHandler).Assembly);
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
