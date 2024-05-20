using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface INhanvienRespositorys
    {
        bool AddNhanvien(Nhanvien obj);
        bool DeleteNhanvien(string id);
        bool UpdateNhanvien(Nhanvien obj);
        List<Nhanvien> GetAllNhanvien();
        Nhanvien GetNhanvienById(string id);
    }
}
