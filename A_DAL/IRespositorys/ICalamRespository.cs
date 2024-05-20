using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositorys
{
    public interface ICalamRespositorys
    {
        bool AddCalam(Calam obj);
        bool DeleteCalam(string id);
        bool UpdateCalam(Calam obj);
        List<Calam> GetCalamList();
        Calam GetCalamById(string id);
    }
}
