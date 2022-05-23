
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositoris
{
    public interface IClubRepository : IRepository<Club>
    {
        Task<IList<Club>> GetClubByName(string name);
    }
}
