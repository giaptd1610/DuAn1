using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ICalamServices
    {
        bool AddCalam(Calam obj);
        bool DeleteCalam(string id);
        bool UpdateCalam(Calam obj);
        List<Calam> GetAllCalam();
        Calam GetCalamById(string id);
    }
}
