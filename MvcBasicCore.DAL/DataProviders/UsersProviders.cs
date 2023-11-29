using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcBasicCore.Entity;

namespace MvcBasicCore.DAL.DataProviders
{
    public class UsersProviders
    {
        ApplicationDBContext _ctxt;
        public UsersProviders(ApplicationDBContext ctxt)
        {
            _ctxt = ctxt;
        }
        public void add(User user)
        {
            _ctxt.Users.Add(user);
            _ctxt.SaveChanges();
        }

        public List<User> getUsers()
        {
            return _ctxt.Users.ToList();
        }

        public List<User> getUser(string UserName, string Password)
        {
            return _ctxt.Users.Where(c=>c.UserName==UserName && c.Password==Password).ToList();
        }



    }
}
