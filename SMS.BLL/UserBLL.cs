using SMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public bool LoginSystem(string uName, string uPwd)
        {
            int userId = userDAL.Login(uName, uPwd);
            if (userId > 0)
                return true;
            else
                return false;
        }
    }
}
