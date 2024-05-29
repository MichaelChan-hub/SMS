using DAL.Common;
using SMS.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL
{
    public class UserDAL:BaseDAL<UserInfo>
    {
        public int Login(string userName,string pwd)
        {
            string strWhere = "UserName=@userName and Password=@userPwd and UserState=1 and IsDeleted=0";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName",userName),
                 new SqlParameter("@userPwd",pwd)
            };
            UserInfo user = GetModel(strWhere, "UserId", paras);
            if (user != null)
                return user.UserId;
            else
                return 0;

        }
    }
}
