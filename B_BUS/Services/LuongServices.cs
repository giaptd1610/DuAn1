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
    public class LuongServices : ILuongServices
    {
        Duan1Context _duan1Context;
        ILuongRespositorys _respositorys;
        public LuongServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new LuongRespositorys();
        }
        public bool AddLuong(Luong obj)
        {
            _respositorys.AddLuong(obj);
            return true;
        }

        public bool DeleteLuong(Guid id)
        {
            _respositorys.DeleteLuong(id);
            return true;
        }

        public List<Luong> GetAllLuong()
        {
            return _respositorys.GetAllLuong();
        }

        public Luong GetLuongById(Guid id)
        {
            return _respositorys.GetLuongById(id);
        }

        public bool UpdateLuong(Luong obj)
        {
            _respositorys.UpdateLuong(obj);
            return true;
        }
    }
}
