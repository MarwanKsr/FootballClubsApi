
using Catalog.DataTransferObjects.Responses;
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business
{
     public interface IClubServise
    {
        Task<IList<ClubDisplayResponse>> GetClubs();
        Task<IList<Club>> GetClubsWithAllDetails();
    }
}
