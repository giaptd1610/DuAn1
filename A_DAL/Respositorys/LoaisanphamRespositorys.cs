using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class LoaisanphamRespositorys : ILoaisanphamRespositorys
    {
        Duan1Context _duan1Context;
        public LoaisanphamRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddLoaisanpham(Loaisanpham obj)
        {
            try
            {
                _duan1Context.Loaisanphams.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLoaisanpham(Guid id)
        {
            try
            {
                var idLSP = _duan1Context.Loaisanphams.Find(id);
                _duan1Context.Loaisanphams.Remove(idLSP);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Loaisanpham> GetAllLoaisanpham()
        {
            return _duan1Context.Loaisanphams.ToList();
        }

        public Loaisanpham GetLoaisanphamById(Guid id)
        {
            return _duan1Context.Loaisanphams.Find(id);
        }

        public bool UpdateLoaisanpham(Loaisanpham obj)
        {
            try
            {
                _duan1Context.Loaisanphams.Update(obj);
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
