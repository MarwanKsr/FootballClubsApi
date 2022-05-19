
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.DataAccess.Repositoris;
using Catalog.DataTransferObjects.Responses;
using Catalog.Entities;

namespace Catalog.Business
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
