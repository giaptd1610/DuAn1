using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IKhuyenmaiServices
    {
        bool AddKhuyenmai(Khuyenmai obj);
        bool DeleteKhuyenmai(string id);
        bool UpdateKhuyenmai(Khuyenmai obj);
        List<Khuyenmai> GetAllKhuyenmai();
        Khuyenmai GetKhuyenmaiById(string id);
    }
}
