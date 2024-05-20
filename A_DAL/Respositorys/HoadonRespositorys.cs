using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class HoadonRespositorys : IHoadonRespositorys
    {
        Duan1Context _duan1Context;

        public HoadonRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddHoadon(Hoadon obj)
        {
            try
            {
                _duan1Context.Hoadons.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoadon(Guid id)
        {
            try
            {
                var idHoadon = _duan1Context.Hoadons.Find(id);
                _duan1Context.Hoadons.Remove(idHoadon);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Hoadon> GetAllHoadon()
        {
            return _duan1Context.Hoadons.ToList();
        }

        public Hoadon GetHoadonById(Guid id)
        {
            return _duan1Context.Hoadons.Find(id);
        }

        public bool UpdateHoadon(Hoadon obj)
        {
            try
            {
                _duan1Context.Hoadons.Update(obj);
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
