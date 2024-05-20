using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ILoaisanphamservices
    {
        bool AddLoaisanpham(Loaisanpham obj);
        bool DeleteLoaisanpham(Guid id);
        bool UpdateLoaisanpham(Loaisanpham obj);
        List<Loaisanpham> GetAllLoaisanpham();
        Loaisanpham GetLoaisanphamById(Guid id);
    }
}
