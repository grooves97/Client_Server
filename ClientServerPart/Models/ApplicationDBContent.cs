using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace ClientServerPart.Models
{
    public class ApplicationDBContent: DbContext
    {
        public DbSet<CleverItem> CleverItems { get; set; }

        public ApplicationDBContent(DbContextOptions<ApplicationDBContent> options) : base(options) { Database.EnsureCreated(); }        
          
        
    }
}
