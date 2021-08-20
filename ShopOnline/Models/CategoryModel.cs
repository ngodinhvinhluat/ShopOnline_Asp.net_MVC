using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private ShopOnlineDBContext context = null;
        public CategoryModel()
        {
            context = new ShopOnlineDBContext();
        }
        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }
        public int Create(string Name, string Alias,int ?ParentID,int? Order,bool? Status)
        {
            var Params = new SqlParameter[]
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@Alias",Alias),
                new SqlParameter("@ParentID",ParentID),
                new SqlParameter("@Order",Order),
                new SqlParameter("@Status",Status)
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Category_Insert @Name,@Alias,@ParentID,@Order,@Status", Params);
            return res;
        }
    }
}
