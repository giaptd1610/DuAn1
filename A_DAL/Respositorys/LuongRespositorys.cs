using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class LuongRespositorys : ILuongRespositorys
    {
        Duan1Context _duan1Context;
        public LuongRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddLuong(Luong obj)
        {
            try
            {
                _duan1Context.Luongs.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLuong(Guid id)
        {
            try
            {
                var idLuong = _duan1Context.Luongs.Find(id);
                _duan1Context.Luongs.Remove(idLuong);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Luong> GetAllLuong()
        {
            return _duan1Context.Luongs.ToList();
        }

        public Luong GetLuongById(Guid id)
        {
            return _duan1Context.Luongs.Find(id);
        }

        public bool UpdateLuong(Luong obj)
        {
            try
            {
                _duan1Context.Luongs.Update(obj);
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
