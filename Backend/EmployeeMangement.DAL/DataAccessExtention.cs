﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace EmployeeMangement.DAL
{
    public static class DataAccessExtention
    {
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("default");
            services.AddDbContext<AppContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        }
    }
}
