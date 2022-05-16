using AutoMapper;
using Country.DataTransferObjects.Responses;
using Country.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Club, ClubDisplayResponse>();
        }
        
    }
}
