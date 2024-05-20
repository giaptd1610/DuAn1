using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class NhanvienRespositorys : INhanvienRespositorys
    {
        Duan1Context _duan1Context;
        public NhanvienRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddNhanvien(Nhanvien obj)
        {
            try
            {
                _duan1Context.Nhanviens.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNhanvien(string id)
        {
            try
            {
                var idNV = _duan1Context.Nhanviens.Find(id);
                _duan1Context.Nhanviens.Remove(idNV);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Nhanvien> GetAllNhanvien()
        {
            return _duan1Context.Nhanviens.ToList();
        }

        public Nhanvien GetNhanvienById(string id)
        {
            return _duan1Context.Nhanviens.Find(id);
        }

        public bool UpdateNhanvien(Nhanvien obj)
        {
            try
            {
                _duan1Context.Nhanviens.Update(obj);
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
