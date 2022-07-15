using AdventureWorksNS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksNS.data //cambiar con el nombreNS
{
    public static class AdventureWorksContextExtension
    {
        public static IServiceCollection AdvetureWorksDBcontext(
            this IServiceCollection services,
            string strCnx = "Data Source=MSI;Initial Catalog=AdventureWorksLT2019;Integrated Security=false;User=soporte;Password=12003906;")
        {
            //Este sera el puente de Blazor
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }
    }
}
