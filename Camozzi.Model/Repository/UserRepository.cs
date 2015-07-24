using System;
using System.Collections.Generic;
using System.Linq;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public class UserRepository : IUserRepository
    {

        public UserRepository()
        {
            UpdateContext();
        }

        private List<UserDto> _users = new List<UserDto>();

        public List<UserDto> GetAll()
        {
            return _users;
        }

        public List<UserDto> FindByDept(int id)
        {
            return (from userDto in _users where userDto.DeptId == id select userDto).ToList();
        }

        public event Action UserUpdated;

        public UserDto FindById(int id)
        {
            return _users.Find(x => x.Id == id);
        }

        public UserDto FindByName(string name)
        {
            return _users.Find(x => x.Name.Contains(name));
        }

        public void Add(UserDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.AddUserAsync(t);
                UpdateContext();
            }
        }

        public void Delete(UserDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.DeleteUserAsync(t);
                UpdateContext();
            }
        }

        public void Update(UserDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.UpdateUserAsync(t);
                UpdateContext();
            }
        }

        public void UpdateContext()
        {
            try
            {
                using (var client = new CServiceClient("BasicHttpBinding_ICService"))
                {
                    _users = client.GetUsers().ToList();
                }
                if (UserUpdated != null) UserUpdated();
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}