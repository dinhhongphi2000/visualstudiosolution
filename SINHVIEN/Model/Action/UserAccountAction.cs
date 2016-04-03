using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Framework;
using System.Data.SqlClient;
namespace Model.Action
{
    public class UserAccountAction
    {
        NhatruongDbContext _dbContext;
        public UserAccountAction()
        {
            _dbContext = new NhatruongDbContext();
        }
        public bool Login(string username, string password)
        {
            object[] param =
            {
                new SqlParameter("@UserName",username),
                new SqlParameter("@PassWord",password)
            };

            var res = _dbContext.Database.SqlQuery<bool>("exec Sp_Account_Login @UserName, @PassWord", param).SingleOrDefault();
            return res;
        }
    }
}
