using Hospital_management_system.DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }
        public bool LoginValidation(string usename,string password)
        {
            return userDataAccess.LoginValidation(usename,password);
        }
    }
}
