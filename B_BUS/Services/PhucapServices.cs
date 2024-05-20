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
    public class PhucapServices : IPhucapServices
    {
        Duan1Context _duan1Context;
        IPhucapRespositorys _respositorys;
        public PhucapServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new PhucapRespositorys();
        }
        public bool AddPhucap(Phucap obj)
        {
            _respositorys.AddPhucap(obj);
            return true;
        }

        public bool DeletePhucap(Guid id)
        {
            _respositorys.DeletePhucap(id);
            return true;
        }

        public List<Phucap> GetAllPhucap()
        {
            return _respositorys.GetAllPhucaps();
        }

        public Phucap GetPhucapById(Guid id)
        {
            return _respositorys.GetPhucapById(id);
        }

        public bool UpdatePhucap(Phucap obj)
        {
            _respositorys.UpdatePhucap(obj);
            return true;
        }
    }
}
