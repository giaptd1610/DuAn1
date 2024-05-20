using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IBanServices
    {
        bool AddBan(Ban obj);
        bool DeleteBan(string id);
        bool UpdateBan(Ban obj);
        List<Ban> GetAllBan();
        Ban GetBanById(string id);
    }
}
