
using TemplateBackend.Models;
     using TemplateBackend.Repositories;
     using System.Collections.Generic;
     using System.Threading.Tasks;

     namespace TemplateBackend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _userRepository.GetAllUsersAsync();
        public async Task<User> GetUserByIdAsync(int id) => await _userRepository.GetUserByIdAsync(id);
        public async Task<User> AddUserAsync(User user) => await _userRepository.AddUserAsync(user);
        public async Task<User> UpdateUserAsync(User user) => await _userRepository.UpdateUserAsync(user);
        public async Task DeleteUserAsync(int id) => await _userRepository.DeleteUserAsync(id);
    }
}