using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class BanHoadonRespositorys : IBanHoadonRespositorys
    {
        Duan1Context _duan1Context;
        public BanHoadonRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddBanHoaDon(BanHoadon obj)
        {
            try
            {
                _duan1Context.BanHoadons.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelBanHoaDon(string id)
        {
            try
            {
                var idBanHoadon = _duan1Context.BanHoadons.Where(banhd => banhd.Maban == id).First();
                _duan1Context.BanHoadons.Remove(idBanHoadon);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BanHoadon> GetBanHoadonAll()
        {
            return _duan1Context.BanHoadons.ToList();
        }

        public BanHoadon GetBanHoadonById(string id)
        {
            return _duan1Context.BanHoadons.Find(id);
        }

        public bool UpdateBanHoaDon(BanHoadon obj)
        {
            try
            {
                _duan1Context.BanHoadons.Update(obj);
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
