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
    public class CalamServices : ICalamServices
    {
        Duan1Context _duan1Context;
        ICalamRespositorys _respositorys;
        public CalamServices()
        {
            _duan1Context = new Duan1Context();
            _respositorys = new CalamRespositorys();
        }
        public bool AddCalam(Calam obj)
        {
            _respositorys.AddCalam(obj);
            return true;
        }

        public bool DeleteCalam(string id)
        {
            _respositorys.DeleteCalam(id);
            return true;
        }

        public List<Calam> GetAllCalam()
        {
            return _respositorys.GetCalamList();
        }

        public Calam GetCalamById(string id)
        {
            return _respositorys.GetCalamById(id);
        }

        public bool UpdateCalam(Calam obj)
        {
            _respositorys.UpdateCalam(obj);
            return true;
        }
    }
}
