using System.Threading.Tasks;
using UdemyCourse.API.Models;

namespace UdemyCourse.API.Services.Auth
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}