using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ILuongServices
    {
        bool AddLuong(Luong obj);
        bool DeleteLuong(Guid id);
        bool UpdateLuong(Luong obj);
        List<Luong> GetAllLuong();
        Luong GetLuongById(Guid id);
    }
}
