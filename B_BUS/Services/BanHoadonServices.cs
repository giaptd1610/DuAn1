using A_DAL.IRespositorys;
using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class BanHoadonServices : IBanHoadonServices
    {
        Duan1Context _duan1Context;
        IBanHoadonRespositorys _respositorys;

        public BanHoadonServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new BanHoadonRespositorys();
        }
        public bool AddBanHoadon(BanHoadon obj)
        {
            _respositorys.AddBanHoaDon(obj);
            return true;
        }

        public bool DeleteBanHoadon(string id)
        {
            _respositorys.DelBanHoaDon(id);
            return true;
        }

        public List<BanHoadon> GetAllBanHoadon()
        {
            return _respositorys.GetBanHoadonAll();
        }

        public BanHoadon GetBanHoadonById(string id)
        {
            return _respositorys.GetBanHoadonById(id);
        }

        public bool UpdateBanHoadon(BanHoadon obj)
        {
            _respositorys.UpdateBanHoaDon(obj);
            return true;
        }
    }
}
