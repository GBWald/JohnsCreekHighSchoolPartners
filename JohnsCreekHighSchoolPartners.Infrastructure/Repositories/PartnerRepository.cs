using JohnsCreekHighSchoolPartners.Application.Interfaces;
using JohnsCreekHighSchoolPartners.Domain.Model;
using JohnsCreekHighSchoolPartners.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace JohnsCreekHighSchoolPartners.Infrastructure.Repositories
{
    //Class that makes the tasks that were defined in IPartnerRepositories' Interface
    public class PartnerRepository : IPartnerRepository
    {
        //Defining context
        private readonly JohnsCreekHighSchoolPartnersDbContext context;

        //Constructor that defines a factory for creating instances of DbContext
        public PartnerRepository(IDbContextFactory<JohnsCreekHighSchoolPartnersDbContext> factory)
        {
            //Creates a new instanse of context
            context = factory.CreateDbContext();

        }

        //Task that will create partners
        public async Task Create(Partner partner)
        {
            try
            {
                //add the partner to partners set
                await context.Partners.AddAsync(partner);

                //save changes to the database
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Task that will delete partners
        public async Task Delete(int id)
        {
            try
            {
                //Find the partner who i want to delete
                var partner = await GetById(id);

                //if the partner is there
                if (partner != null)
                {
                    //Remove the partner from the partner set
                    context.Partners.Remove(partner);

                    //Save changes to the database
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Task that will save all of the partners to a list
        public async Task<List<Partner>> GetAll()
        {
            try
            {
                //get all the partners from the set to a list
                var partners = await context.Partners.ToListAsync();

                //Return the normal list
                return partners;

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Task that will save all of the partners to a list except it will reverse the order
        public async Task<List<Partner>> GetAllReversed()
        {
            try
            {
                //get all the partners from the set to a list
                var partners = await context.Partners.ToListAsync();

                //Reverse the list
                partners.Reverse();

                //return the reversed list
                return partners;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Task that gets a partner by their induvidual Id
        public async Task<Partner?> GetById(int id)
        {
            try
            {
                //Find partner in the set by id 
                var partner = await context.Partners.FindAsync(id);

                //Return the partner
                return partner;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Task that updates/modifies a partner
        public async Task Update(Partner partner)
        {
            try
            {
                //Modify and Update the partner 
                context.Entry(partner).State = EntityState.Modified;

                //Save the changes to the database
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
