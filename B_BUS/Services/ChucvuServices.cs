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
    public class ChucvuServices : IChucvuServices
    {
        Duan1Context _duan1Context;
        IChucvuRespositorys _respositorys;
        public ChucvuServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new ChucvuRespositorys();
        }
        public bool AddChucvu(Chucvu obj)
        {
            _respositorys.AddChucvu(obj);
            return true;
        }

        public bool DeleteChucvu(Guid id)
        {
            _respositorys.DeleteChucvu(id);
            return true;
        }

        public List<Chucvu> GetAllChucvu()
        {
            return _respositorys.GetAllChucvu();
        }

        public Chucvu GetChucvuById(Guid id)
        {
            return _respositorys.GetChucvuById(id);
        }

        public bool UpdateChucvu(Chucvu obj)
        {
            _respositorys.UpdateChucvu(obj);
            return true;
        }
    }
}
