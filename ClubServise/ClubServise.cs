using Country.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Country.DataAccess.Repositoris;
using Country.DataTransferObjects.Responses;
using AutoMapper;

namespace Country.Business
{
    public class ClubServise : IClubServise
    {
        public readonly IClubRepository clubRepository;
        private readonly IMapper mapper;

        public ClubServise (IClubRepository clubRepository, IMapper mapper )
        {
            this.clubRepository = clubRepository;
            this.mapper = mapper;
        }

        public async Task<IList<ClubDisplayResponse>> GetClubs()
        {
            var clubs = await clubRepository.GetAll();
            var result =  mapper.Map<IList<ClubDisplayResponse>>(clubs);
            return  result;
        }

        public async Task<IList<Club>> GetClubsWithAllDetails()
        {
            return await clubRepository.GetAll();
        }
    }
}
