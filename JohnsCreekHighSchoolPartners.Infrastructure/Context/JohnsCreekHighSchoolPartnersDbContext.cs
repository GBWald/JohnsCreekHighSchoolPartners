using JohnsCreekHighSchoolPartners.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace JohnsCreekHighSchoolPartners.Infrastructure.Context
{
    public class JohnsCreekHighSchoolPartnersDbContext: DbContext
    {
        public JohnsCreekHighSchoolPartnersDbContext(DbContextOptions<JohnsCreekHighSchoolPartnersDbContext> options) : base(options)
        {
            
        }

        public DbSet<Partner> Partners { get; set; }
    }
}
