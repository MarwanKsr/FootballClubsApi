using Country.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.DataAccess.Repositoris
{
    public interface IClubRepository : IRepository<Club>
    {
        Task<IEnumerable<Club>> GetClubByName(string name);
    }
}
