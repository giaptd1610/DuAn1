using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ISanphamServices
    {
        bool AddSanpham(Sanpham obj);
        bool DeleteSanpham(string id);
        bool UpdateSanpham(Sanpham obj);
        List<Sanpham> GetAllSanpham();
        Sanpham GetSanphamById(string id);
    }
}
