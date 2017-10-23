using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using ICRC.Domain.Entities;
using System.Data.Entity;

namespace ICRC.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("ICRCContext", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbContextInializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Complaint> complaints { get; set; }
        public DbSet<Request> Requests { get; set; }

        public class ApplicationDbContextInializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
        {
            // initialiser une nouvelle base avec des donnees 
            
        }
    }
}
