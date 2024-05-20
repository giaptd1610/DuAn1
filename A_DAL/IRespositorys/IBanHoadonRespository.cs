using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
    public interface IBanHoadonRespositorys
    {
        bool AddBanHoaDon(BanHoadon obj);
        bool DelBanHoaDon(string id);
        bool UpdateBanHoaDon(BanHoadon obj);
        List<BanHoadon> GetBanHoadonAll();
        BanHoadon GetBanHoadonById(string id);
    }
}
