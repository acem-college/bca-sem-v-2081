
using LMS.Application.Common.Models.Users;
using LMS.Application.Interfaces;

namespace LMS.Application.Services
{
    public class UserService : IUserService
    {
        public UserService() { }

        Task IUserService.CreateAsync(UserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task IUserService.DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<UserVM> IUserService.GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<UserVM>> IUserService.ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task IUserService.UpdateAsync(int id, UserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
