using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
     public class AccountModel
    {
        private ShopOnlineDBContext context = null;
        public AccountModel()
        {
            context = new ShopOnlineDBContext();

        }
        public bool Login(string Username,string Password)
        {
            object[] sqlPrams =
             {
                new SqlParameter("@userName",Username),
                new SqlParameter("@passWord",Password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_User_Login @userName,@passWord,1", sqlPrams).SingleOrDefault();
            return res;
        }

    }
}
