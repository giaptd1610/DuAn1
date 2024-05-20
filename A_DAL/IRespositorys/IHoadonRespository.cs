using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface IHoadonRespositorys
    {
        bool AddHoadon(Hoadon obj);
        bool DeleteHoadon(Guid id);
        bool UpdateHoadon(Hoadon obj);
        List<Hoadon> GetAllHoadon();
        Hoadon GetHoadonById(Guid id);
    }
}
