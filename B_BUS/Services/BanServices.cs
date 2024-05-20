using A_DAL.Respositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRespositorys;
using A_DAL.Models;
using B_BUS.IServices;

namespace B_BUS.Services
{
    public class BanServices : IBanServices
    {
        Duan1Context _duan1Context;
        IBanRespositorys _respositorys;
        public BanServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new BanRespositorys();
        }
        public bool AddBan(Ban obj)
        {
            _respositorys.AddBan(obj);
            return true;
        }

        public bool DeleteBan(string id)
        {
            _respositorys.DeleteBan(id);
            return true;
        }

        public List<Ban> GetAllBan()
        {
            return _respositorys.GetAllBan();
        }

        public Ban GetBanById(string id)
        {
            return _respositorys.GetBanById(id);
        }

        public bool UpdateBan(Ban obj)
        {
            _respositorys.UpdateBan(obj);
            return true;
        }
    }
}
