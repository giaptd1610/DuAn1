using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class ChucvuRespositorys : IChucvuRespositorys
    {
        Duan1Context _duan1Context;
        public ChucvuRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddChucvu(Chucvu obj)
        {
            try
            {
                _duan1Context.Chucvus.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteChucvu(Guid id)
        {
            try
            {
                var idChucvu = _duan1Context.Chucvus.Find(id);
                _duan1Context.Chucvus.Remove(idChucvu);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Chucvu> GetAllChucvu()
        {
            return _duan1Context.Chucvus.ToList();
        }

        public Chucvu GetChucvuById(Guid id)
        {
            return _duan1Context.Chucvus.Find(id);
        }

        public bool UpdateChucvu(Chucvu obj)
        {
            try
            {
                _duan1Context.Chucvus.Update(obj);
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
