using MvcBasicCore.BLL.Contracts;
using MvcBasicCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcBasicCore.DAL.DataProviders;

using MvcBasicCore.DAL;
using MvcBasicCore.BLL.Contracts;

namespace MvcBasicCore.BLL
{
    public class UserService : IUserService
    {
        ApplicationDBContext _dbContext;
        UsersProviders usr;
        public UserService(ApplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
            usr = new UsersProviders(_dbContext);
        }
        List<User> IUserService.GetAll()
        {
            
            return usr.getUsers();
        }

        bool IUserService.isValidUser(string userName, string pwd, ref int userID)
        {
            List<User> lst1 = usr.getUser(userName, pwd);
            if (lst1.Count == 0)
                return false;

            return true;
        }
    }
}
