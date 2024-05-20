using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface INhanvienServices
    {
        bool AddNhanvien(Nhanvien obj);
        bool DeleteNhanvien(string id);
        bool UpdateNhanvien(Nhanvien obj);
        List<Nhanvien> GetNhanvienList();
        Nhanvien GetNhanvienById(string id);
    }
}
