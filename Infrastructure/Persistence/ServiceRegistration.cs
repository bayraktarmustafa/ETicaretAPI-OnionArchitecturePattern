using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Repositories;
using Persistence.Repositories;

namespace Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddDbContext<APIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
			services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
			services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
			services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
			services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
			services.AddSingleton<IProductReadRepository, ProductReadRepository>();
			services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();

		}
	}
}
