using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;
namespace Models
{
    public class CategoryModel
    {
        private ShopDbContext _context = null;

        public CategoryModel()
        {
            _context = new ShopDbContext();
        }

        public List<Category> ListAll()
        {
            var result = _context.Database.SqlQuery<Category>("exec Sp_Category_ListAll").ToList();
            return result;
        }

        public int Create(string Name,string Alias,int? ParentID,int? Order,bool? Status)
        {
            object[] param =
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@Alias",Alias),
                new SqlParameter("@ParentID",ParentID),
                new SqlParameter("@Order",Order),
                new SqlParameter("@Status",Status)
            };
            int res = _context.Database.ExecuteSqlCommand("exec Sp_Category_Insert @Name,@Alias,@ParentID,@Order,@Status",param);
            return res;
        }
    }
}
