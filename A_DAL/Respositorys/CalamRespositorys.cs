using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class CalamRespositorys : ICalamRespositorys
    {
        Duan1Context _duan1Context;
        public CalamRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddCalam(Calam obj)
        {
            try
            {
                _duan1Context.Calams.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCalam(string id)
        {
            try
            {
                var idCa = _duan1Context.Calams.Find(id);
                _duan1Context.Calams.Remove(idCa);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Calam GetCalamById(string id)
        {
            return _duan1Context.Calams.Find(id);
        }

        public List<Calam> GetCalamList()
        {
            return _duan1Context.Calams.ToList();
        }

        public bool UpdateCalam(Calam obj)
        {
            try
            {
                _duan1Context.Calams.Update(obj);
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
