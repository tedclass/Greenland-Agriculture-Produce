using System;
using Greenland_Agriculture_Produce.Areas.Identity.Data;
using Greenland_Agriculture_Produce.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Greenland_Agriculture_Produce.Areas.Identity.IdentityHostingStartup))]
namespace Greenland_Agriculture_Produce.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Greenland_Agriculture_ProduceContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Greenland_Agriculture_ProduceContextConnection")));

                services.AddDefaultIdentity<Greenland_Agriculture_ProduceUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Greenland_Agriculture_ProduceContext>();
            });
        }
    }
}