
using Catalog.DataTransferObjects.Requests;
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
        Task<Club> GetClubById(int id);
        Task<IList<Club>> GetClubByName(string name);
        Task<int> AddClub(AddClubRequest request);
        Task UpdateClub(UpdateClubRequest request);
        Task DeleteClub(int id);
        Task<bool> IsClubExists(int id);
    }
}
