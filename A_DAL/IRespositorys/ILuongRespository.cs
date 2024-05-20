using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface ILuongRespositorys
    {
        bool AddLuong(Luong obj);
        bool DeleteLuong(Guid id);
        bool UpdateLuong(Luong obj);
        List<Luong> GetAllLuong();
        Luong GetLuongById(Guid id);
    }
}
