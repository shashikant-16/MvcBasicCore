using MvcBasicCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBasicCore.BLL.Contracts
{
    public interface IUserService
    {
        List<User> GetAll();
        bool isValidUser(string userName, string pwd,ref int userID);

        bool registerUser();
    }
}
