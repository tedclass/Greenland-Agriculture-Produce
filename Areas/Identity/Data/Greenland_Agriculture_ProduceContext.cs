using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greenland_Agriculture_Produce.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Greenland_Agriculture_Produce.Data
{
    public class Greenland_Agriculture_ProduceContext : IdentityDbContext<Greenland_Agriculture_ProduceUser>
    {
        public Greenland_Agriculture_ProduceContext(DbContextOptions<Greenland_Agriculture_ProduceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
