using Country.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.Business
{
    public class ClubServise : IClubServise
    {
        private List<Club> Clubs;

        public ClubServise()
        {
            Clubs = new List<Club>
            {
                new Club { Id = 1, Name = "Real Madriad", CoachsName = "Carlo Ancelotti",
                    StadiumName = "Santiago Bernabéu", PresidentsName = "Florentino Pérez" },
                new Club { Id = 2, Name = "Barcelona", CoachsName = "Xavi hernandez",
                    StadiumName = "Camp nou", PresidentsName = "Joan Laporta" }
            };
        }



        public async Task<List<Club>> GetClubs()
        {
            return Clubs;
        }

    }
}
