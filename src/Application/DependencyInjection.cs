using Microsoft.Extensions.DependencyInjection;
using WebOvin.Application.Interfaces;
using WebOvin.Application.Services;

namespace WebOvin.Application;

public static class DependencyInjection
{
	public static void AddApplicationServices(this IServiceCollection services)
	{
		services.AddScoped<ICustomerService, CustomerService>();
	}
}