using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IBanHoadonServices
    {
        bool AddBanHoadon(BanHoadon obj);
        bool DeleteBanHoadon(string id);
        bool UpdateBanHoadon(BanHoadon obj);
        List<BanHoadon> GetAllBanHoadon();
        BanHoadon GetBanHoadonById(string id);
    }
}
