using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class KhuyenmaiRespositorys : IKhuyenmaiRespositorys
    {
        Duan1Context _duan1Context;
        public KhuyenmaiRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddKhuyenmai(Khuyenmai obj)
        {
            try
            {
                _duan1Context.Khuyenmais.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteKhuyenmai(string id)
        {
            try
            {
                var idKM = _duan1Context.Khuyenmais.Find(id);
                _duan1Context.Khuyenmais.Remove(idKM);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Khuyenmai> GetAllKhuyenmai()
        {
            return _duan1Context.Khuyenmais.ToList();
        }

        public Khuyenmai GetKhuyenmaiById(string id)
        {
            return _duan1Context.Khuyenmais.Find(id);
        }

        public bool UpdateKhuyenmai(Khuyenmai obj)
        {
            try
            {
                _duan1Context.Khuyenmais.Update(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
