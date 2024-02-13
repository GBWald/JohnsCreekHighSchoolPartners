
using JohnsCreekHighSchoolPartners.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace JohnsCreekHighSchoolPartners.Infrastructure.Context
{
    //Inherits from DbContext API, allowing the program to query and save actions relating with my model 
    public class JohnsCreekHighSchoolPartnersDbContext: DbContext
    {
        //Constructor that sets the context options used by JohnsCreekHighSchoolPartnersDbContext 
        public JohnsCreekHighSchoolPartnersDbContext(DbContextOptions<JohnsCreekHighSchoolPartnersDbContext> options) : base(options)
        {
            
        }
        
        //DbSet prop that will represent my a set of my partners
        public DbSet<Partner> Partners { get; set; }
    }
}
