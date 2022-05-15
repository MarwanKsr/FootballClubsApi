using Country.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.Business
{
     public interface IClubServise
    {
        Task<List<Club>> GetClubs();
    }
}
