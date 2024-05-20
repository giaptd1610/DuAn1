using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class PhucapRespositorys : IPhucapRespositorys
    {
        Duan1Context _duan1Context;
        public PhucapRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddPhucap(Phucap obj)
        {
            try
            {
                _duan1Context.Phucaps.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePhucap(Guid id)
        {
            try
            {
                var idPC = _duan1Context.Phucaps.Find(id);
                _duan1Context.Phucaps.Remove(idPC);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Phucap> GetAllPhucaps()
        {
            return _duan1Context.Phucaps.ToList();
        }

        public Phucap GetPhucapById(Guid id)
        {
            return _duan1Context.Phucaps.Find(id);
        }

        public bool UpdatePhucap(Phucap obj)
        {
            try
            {
                _duan1Context.Phucaps.Update(obj);
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
