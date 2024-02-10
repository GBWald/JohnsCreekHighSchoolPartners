using JohnsCreekHighSchoolPartners.Domain.Model;

namespace JohnsCreekHighSchoolPartners.Application.Interfaces
{
    public interface IPartnerRepository
    {
        Task Create(Partner partner);

        Task<List<Partner>> GetAll();

        Task<List<Partner>> GetAllReversed();

        Task<Partner?> GetById(int id);

        Task Update(Partner book);

        Task Delete(int id);
    }
}
