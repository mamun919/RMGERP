using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RMGERP.Data;

[assembly: HostingStartup(typeof(RMGERP.Areas.Identity.IdentityHostingStartup))]
namespace RMGERP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RMGERPContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RMGERPContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<RMGERPContext>();
            });
        }
    }
}