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
    public class SanphamServices : ISanphamServices
    {
        Duan1Context _duan1Context;
        ISanphamRespositorys _respositorys;
        public SanphamServices() 
        {
            _duan1Context = new Duan1Context();
            _respositorys = new SanphamRespositorys();
        }
        public bool AddSanpham(Sanpham obj)
        {
            _respositorys.AddSanpham(obj);
            return true;
        }

        public bool DeleteSanpham(string id)
        {
            _respositorys.DeleteSanpham(id);
            return true;
        }

        public List<Sanpham> GetAllSanpham()
        {
            return _respositorys.GetAllSanpham();
        }

        public Sanpham GetSanphamById(string id)
        {
            return _respositorys.GetSanphamById(id);
        }

        public bool UpdateSanpham(Sanpham obj)
        {
            return _respositorys.UpdateSanpham(obj);
            
        }
    }
}
