using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
    public class SanphamRespositorys : ISanphamRespositorys
    {
        Duan1Context _duan1Context;
        public SanphamRespositorys()
        {
            _duan1Context = new Duan1Context();
        }
        public bool AddSanpham(Sanpham obj)
        {
            try
            {
                _duan1Context.Sanphams.Add(obj);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSanpham(string id)
        {
            try
            {
                var idSP = _duan1Context.Sanphams.Find(id);
                _duan1Context.Sanphams.Remove(idSP);
                _duan1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Sanpham> GetAllSanpham()
        {
            return _duan1Context.Sanphams.ToList();
        }

        public Sanpham GetSanphamById(string id)
        {
            return _duan1Context.Sanphams.Find(id);
        }

        public bool UpdateSanpham(Sanpham obj)
        {
            try
            {
                _duan1Context.Sanphams.Update(obj);
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
