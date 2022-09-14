using BlazorE.Models.Users;

namespace BlazorE.Services.Interfaces
{
    public interface IUserAccess
    {
        public Task<User?> GetByLoginAsync(string login);
        public Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
