using Microsoft.EntityFrameworkCore;
using RegistrationWebsite.Models;

namespace RegistrationWebsite
{
    public class RegistrationWebsiteDbContext : DbContext
    {
        public RegistrationWebsiteDbContext(DbContextOptions<RegistrationWebsiteDbContext> options) :
           base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}