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
    public class NhanvienServices : INhanvienServices
    {
        Duan1Context _duan1Context;
        INhanvienRespositorys _respositorys;
        public NhanvienServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new NhanvienRespositorys();
        }
        public bool AddNhanvien(Nhanvien obj)
        {
            _respositorys.AddNhanvien(obj);
            return true;
        }

        public bool DeleteNhanvien(string id)
        {
            _respositorys.DeleteNhanvien(id);
            return true;
        }

        public Nhanvien GetNhanvienById(string id)
        {
            return _respositorys.GetNhanvienById(id);
        }

        public List<Nhanvien> GetNhanvienList()
        {
            return _respositorys.GetAllNhanvien();
        }

        public bool UpdateNhanvien(Nhanvien obj)
        {
            _respositorys.UpdateNhanvien(obj);
            return true;
        }
    }
}
