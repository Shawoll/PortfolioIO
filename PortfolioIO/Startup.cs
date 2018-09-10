using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PortfolioIO.Orders.Services;

namespace PortfolioIO.Web
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IOrderService, OrderService>();
            services.AddSingleton<ICustomerService, CustomerService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // whenever our endpoint is hit in the browser
            // will automaticaly surface the "index.html"
            app.UseDefaultFiles();
            // enable static file server 
            app.UseStaticFiles();

        }
    }
}
