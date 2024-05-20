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
    public class LoaisanphamServices : ILoaisanphamservices
    {
        Duan1Context _duan1Context;
        ILoaisanphamRespositorys _respositorys;
        public LoaisanphamServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new LoaisanphamRespositorys();
        }
        public bool AddLoaisanpham(Loaisanpham obj)
        {
            _respositorys.AddLoaisanpham(obj);
            return true;
        }

        public bool DeleteLoaisanpham(Guid id)
        {
            _respositorys.DeleteLoaisanpham(id);
            return true;
        }

        public List<Loaisanpham> GetAllLoaisanpham()
        {
            return _respositorys.GetAllLoaisanpham();
        }

        public Loaisanpham GetLoaisanphamById(Guid id)
        {
            return _respositorys.GetLoaisanphamById(id);
        }

        public bool UpdateLoaisanpham(Loaisanpham obj)
        {
            _respositorys.UpdateLoaisanpham(obj);
            return true;
        }
    }
}
