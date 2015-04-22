using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public class UserRepository : IUserRepository
    {

        public UserRepository()
        {
            UpdateUsers();
        }

        private List<User> _users = new List<User>();

        public List<User> GetAll()
        {
            return _users;
        }

        public List<User> FindByDept(int id)
        {
            return (from user in _users where user.DeptId == id select user).ToList();
        }

        public event Action UserUpdated;

        public User FindById(int id)
        {
            return _users.Find(x => x.Id == id);
        }

        public User FindByName(string name)
        {
            return _users.Find(x => x.Name.Contains(name));
        }

        public void Add(User t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.AddUserAsync(t);
                UpdateUsers();
            }
        }

        public void Delete(User t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.DeleteUserAsync(t);
                UpdateUsers();
            }
        }

        public void Update(User t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.UpdateUserAsync(t);
                UpdateUsers();
            }
        }

        private void UpdateUsers()
        {
            try
            {
                using (var client = new CServiceClient("NetTcpBinding_ICService"))
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