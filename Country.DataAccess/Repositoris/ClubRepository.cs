
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositoris
{
    public class ClubRepository : IClubRepository
    {
        private List<Club> clubs;
        
        public ClubRepository()
        {
            clubs = new List<Club>
            {
                new Club { Id = 1, Name = "Real Madriad", CoachsName = "Carlo Ancelotti",
                    StadiumName = "Santiago Bernabéu", PresidentsName = "Florentino Pérez" },
                new Club { Id = 2, Name = "Barcelona", CoachsName = "Xavi hernandez",
                    StadiumName = "Camp nou", PresidentsName = "Joan Laporta" }
            };
        }
        public async Task<IList<Club>> GetAll()
        {
            return clubs;
        }

        public Task<Club> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
