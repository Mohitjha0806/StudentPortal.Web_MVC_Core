using Microsoft.EntityFrameworkCore;
using Studentportal.Web.Models.Entities;

namespace Studentportal.Web.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
