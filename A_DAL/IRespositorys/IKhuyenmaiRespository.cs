using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface IKhuyenmaiRespositorys
    {
        bool AddKhuyenmai(Khuyenmai obj);
        bool DeleteKhuyenmai(string id);
        bool UpdateKhuyenmai(Khuyenmai obj);
        List<Khuyenmai> GetAllKhuyenmai();
        Khuyenmai GetKhuyenmaiById(string id);
    }
}
