using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChucvuServices
    {
        bool AddChucvu(Chucvu obj);
        bool DeleteChucvu(Guid id);
        bool UpdateChucvu(Chucvu obj);
        List<Chucvu> GetAllChucvu();
        Chucvu GetChucvuById(Guid id);
    }
}
