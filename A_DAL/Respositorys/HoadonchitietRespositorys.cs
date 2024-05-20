using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class HoadonchitietRespositorys : IHoadonchitietRespositorys
    {
        Duan1Context _duan1Context;
        public HoadonchitietRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddHoadonchitiet(Hoadonchitiet obj)
        {
            try
            {
                _duan1Context.Hoadonchitiets.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoadonchitiet(Guid mahd ,string id)
        {
            try
            {
                var idHDCT = _duan1Context.Hoadonchitiets.ToList().Where(hdct =>hdct.Mahd == mahd && hdct.Masp == id).FirstOrDefault();
                _duan1Context.Hoadonchitiets.Remove(idHDCT);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Hoadonchitiet> GetHoadonchitietAll()
        {
            return _duan1Context.Hoadonchitiets.ToList();
        }

        public Hoadonchitiet GetHoadonchitietById(Guid id)
        {
            return _duan1Context.Hoadonchitiets.Find(id);
        }

        public bool UpdateHoadonchitiet(Hoadonchitiet obj)
        {
            try
            {
                _duan1Context.Hoadonchitiets.Update(obj);
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
