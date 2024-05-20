using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface IPhucapRespositorys
    {
        bool AddPhucap(Phucap obj);
        bool DeletePhucap(Guid id);
        bool UpdatePhucap(Phucap obj);
        List<Phucap> GetAllPhucaps();
        Phucap GetPhucapById(Guid id);
    }
}
