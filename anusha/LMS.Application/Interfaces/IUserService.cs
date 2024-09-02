using LMS.Application.Common.Models.Users;

namespace LMS.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task CreateAsync(UserVM user, CancellationToken cancellationToken);
        Task UpdateAsync(int id, UserVM user, CancellationToken cancellationToken);

        Task DeleteAsync(int id, CancellationToken cancellationToken);
     
    }
}
