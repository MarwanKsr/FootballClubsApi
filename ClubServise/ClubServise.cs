
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.DataAccess.Repositoris;
using Catalog.DataTransferObjects.Requests;
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

        public async Task<int> AddClub(AddClubRequest request)
        {
            var club = mapper.Map<Club>(request);
            await clubRepository.Add(club);
            return club.Id;
        }

        public async Task DeleteClub(int id)
        {
           await clubRepository.Delate(id);
        }

        public async Task<Club> GetClubById(int id)
        {
            var club = await clubRepository.GetById(id);
            return club;
        }

        public async Task<IList<Club>> GetClubByName(string name)
        {
            var club = await clubRepository.GetClubByName(name);
            return club;

        }

        public async Task<IList<ClubDisplayResponse>> GetClubs()
        {
            var clubs = await clubRepository.GetAll();
            var result =  mapper.Map<IList<ClubDisplayResponse>>(clubs);
            return  result;
        }

        public async Task<bool> IsClubExists(int id)
        {
            return await clubRepository.IsExists(id);
        }

        public async Task UpdateClub(UpdateClubRequest request)
        {
            var club = mapper.Map<Club>(request);
            await clubRepository.Update(club);
           

        }
    }
}
