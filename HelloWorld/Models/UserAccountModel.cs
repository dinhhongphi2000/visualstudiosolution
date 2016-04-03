using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class UserAccountModel
    {
        private ShopDbContext context = null;

        public UserAccountModel()
        {
            context = new ShopDbContext();
        }
        public bool Login(string username, string password)
        {
            object[] Sqlparams =
            {
                new SqlParameter("@Username",username),
                new SqlParameter("@Password",password)
            };
            var res = context.Database.SqlQuery<bool>("exec Sp_Account_Login @Username, @Password", Sqlparams).SingleOrDefault();
            return res;
        }



    }
}
