using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface IHoadonchitietRespositorys
    {
        bool AddHoadonchitiet(Hoadonchitiet obj);
        bool DeleteHoadonchitiet(Guid mahd,string id);
        bool UpdateHoadonchitiet(Hoadonchitiet obj);
        List<Hoadonchitiet> GetHoadonchitietAll();
        Hoadonchitiet GetHoadonchitietById(Guid id);
    }
}
