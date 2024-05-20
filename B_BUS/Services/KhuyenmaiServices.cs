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
    public class KhuyenmaiServices : IKhuyenmaiServices
    {
        Duan1Context _duan1Context;
        IKhuyenmaiRespositorys _respositories;
        public KhuyenmaiServices()
        {
            _duan1Context = new Duan1Context();
            _respositories = new KhuyenmaiRespositorys();
        }
        public bool AddKhuyenmai(Khuyenmai obj)
        {
            _respositories.AddKhuyenmai(obj);
            return true;
        }

        public bool DeleteKhuyenmai(string id)
        {
            _respositories.DeleteKhuyenmai(id);
            return true;
        }

        public List<Khuyenmai> GetAllKhuyenmai()
        {
            return _respositories.GetAllKhuyenmai();
        }

        public Khuyenmai GetKhuyenmaiById(string id)
        {
            return _respositories.GetKhuyenmaiById(id);
        }

        public bool UpdateKhuyenmai(Khuyenmai obj)
        {
            _respositories.UpdateKhuyenmai(obj);
            return true;
        }
    }
}