using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IPhucapServices
    {
        bool AddPhucap(Phucap obj);
        bool DeletePhucap(Guid id);
        bool UpdatePhucap(Phucap obj);
        List<Phucap> GetAllPhucap();
        Phucap GetPhucapById(Guid id);
    }
}
