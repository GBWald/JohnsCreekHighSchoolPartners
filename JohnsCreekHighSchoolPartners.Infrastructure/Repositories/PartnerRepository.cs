using JohnsCreekHighSchoolPartners.Application.Interfaces;
using JohnsCreekHighSchoolPartners.Domain.Model;
using JohnsCreekHighSchoolPartners.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace JohnsCreekHighSchoolPartners.Infrastructure.Repositories
{
    public class PartnerRepository: IPartnerRepository
    {
        private readonly JohnsCreekHighSchoolPartnersDbContext context;

        public PartnerRepository(IDbContextFactory<JohnsCreekHighSchoolPartnersDbContext> factory)
        {
            context = factory.CreateDbContext();
            
        }

        public async Task Create(Partner partner)
        {
            try
            {
                await context.Partners.AddAsync(partner);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var partner = await GetById(id);
                if (partner != null)
                {
                    context.Partners.Remove(partner);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Partner>> GetAll()
        {
            try
            {
                var partners = await context.Partners.ToListAsync();
                return partners;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Partner?> GetById(int id)
        {
            try
            {
                //var partner = await context.Partners.FirstOrDefaultAsync(e => e.Id == id);
                var partner = await context.Partners.FindAsync(id);
                return partner;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Update(Partner partner)
        {
            try
            {
                context.Entry(partner).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
