using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Framework;
namespace Model.Action
{
    public class SinhVienAction
    {
        NhatruongDbContext _dbContext = null;
        public SinhVienAction()
        {
            _dbContext = new NhatruongDbContext();
        }

        public List<SINHVIEN> GetDanhSachSV()
        {
            var result = _dbContext.Database.SqlQuery<SINHVIEN>("exec Sp_Getsinhvien").ToList<SINHVIEN>();
            return result;
        }
    }
}
