using UserManagement.Models;

namespace UserManagement.Services
{
    public class UserService
    {
        private List<User> _users = new List<User>();

        public Task<List<User>> GetUsersAsync()
        {
            return Task.FromResult(_users);
        }

        public Task<User?> GetUserAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            return Task.FromResult(user);
        }

        public Task<User> CreateUserAsync(User user)
        {
            user.Id = _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(user);
            return Task.FromResult(user);
        }

        public Task<bool> UpdateUserAsync(int id, User updatedUser)
        {
            var userIndex = _users.FindIndex(u => u.Id == id);
            if (userIndex == -1) return Task.FromResult(false);

            updatedUser.Id = id;
            _users[userIndex] = updatedUser;
            return Task.FromResult(true);
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return Task.FromResult(false);

            _users.Remove(user);
            return Task.FromResult(true);
        }
    }
}