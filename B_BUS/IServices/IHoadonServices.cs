using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoadonServices
    {
        bool AddHoadon(Hoadon obj);
        bool DeleteHoadon(Guid id);
        bool UpdateHoadon(Hoadon obj);
        List<Hoadon> GetHoadonAll();
        Hoadon GetHoadonById(Guid id);
    }
}
