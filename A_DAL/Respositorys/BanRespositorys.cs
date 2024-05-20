using A_DAL.IRespositorys;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class BanRespositorys : IBanRespositorys
    {
        Duan1Context _duan1Context;

        public BanRespositorys()
        {
            _duan1Context = new Duan1Context();
        }

        public bool AddBan(Ban obj)
        {
            try
            {
                _duan1Context.Bans.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteBan(string id)
        {
            try
            {
                var idBan = _duan1Context.Bans.Find(id);
                _duan1Context.Bans.Remove(idBan);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ban> GetAllBan()
        {
            return _duan1Context.Bans.ToList();
        }

        public Ban GetBanById(string id)
        {
            return _duan1Context.Bans.Find(id);
        }

        public bool UpdateBan(Ban obj)
        {
            try
            {
                _duan1Context.Bans.Update(obj);
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
