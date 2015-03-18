using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Model.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public override User FindByName(string name)
        {
            return _context.Users.First(x => x.Name.Contains(name));
        }

        public override void Update(User t)
        {
            _context.Users.Attach(t);
            var entry = _context.Entry(t);
            entry.Property(e => e.Name).IsModified = true;
            entry.Property(e => e.Password).IsModified = true;
            entry.Property(e => e.Phone).IsModified = true;
            entry.Property(e => e.Mail).IsModified = true;
            entry.Property(e => e.Comment).IsModified = true;
            _context.SaveChanges();
        }

        public List<User> FindByDept(int id)
        {
                IQueryable<User> users = (from us in _context.Users where us.DeptId == id select us);
                return users.ToList();
        }
    }
}
