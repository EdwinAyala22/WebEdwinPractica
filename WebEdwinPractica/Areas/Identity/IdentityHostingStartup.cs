using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebEdwinPractica.Data;

[assembly: HostingStartup(typeof(WebEdwinPractica.Areas.Identity.IdentityHostingStartup))]
namespace WebEdwinPractica.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<WebEdwinPracticaContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("WebEdwinPracticaContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<WebEdwinPracticaContext>();
            });
        }
    }
}