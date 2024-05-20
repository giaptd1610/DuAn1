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
    public class HoadonchitietServices : IHoadonchitietServices
    {
        Duan1Context _duan1Context;
        IHoadonchitietRespositorys _respositorys;
        public HoadonchitietServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new HoadonchitietRespositorys();
        }
        public bool AddHoadonchitiet(Hoadonchitiet obj)
        {
            _respositorys.AddHoadonchitiet(obj);
            return true;
        }

        public bool DeleteHoadonchitiet(Guid mahd, string id)
        {
            _respositorys.DeleteHoadonchitiet(mahd, id);
            return true;
        }

        public List<Hoadonchitiet> GetAllHoadonchitet()
        {
            return _respositorys.GetHoadonchitietAll();
        }

        public Hoadonchitiet GetHoadonchitietById(Guid id)
        {
            return _respositorys.GetHoadonchitietById(id);
        }

        public bool UpdateHoadonchitiet(Hoadonchitiet obj)
        {
            _respositorys.UpdateHoadonchitiet(obj);
            return true;
        }
    }
}
