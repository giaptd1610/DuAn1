using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoadonchitietServices
    {
        bool AddHoadonchitiet(Hoadonchitiet obj);
        bool DeleteHoadonchitiet(Guid mahd, string id);
        bool UpdateHoadonchitiet(Hoadonchitiet obj);
        List<Hoadonchitiet> GetAllHoadonchitet();
        Hoadonchitiet GetHoadonchitietById(Guid id);
    }
}
