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
    public class HoadonServices : IHoadonServices
    {
        Duan1Context _duan1Context;
        IHoadonRespositorys _respositorys;

        public HoadonServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new HoadonRespositorys();
        }
        public bool AddHoadon(Hoadon obj)
        {
            _respositorys.AddHoadon(obj);
            return true;
        }

        public bool DeleteHoadon(Guid id)
        {
            _respositorys.DeleteHoadon(id);
            return true;
        }

        public List<Hoadon> GetHoadonAll()
        {
            return _respositorys.GetAllHoadon();
        }

        public Hoadon GetHoadonById(Guid id)
        {
            return _respositorys.GetHoadonById(id);
        }

        public bool UpdateHoadon(Hoadon obj)
        {
            return _respositorys.UpdateHoadon(obj);
        }
    }
}
