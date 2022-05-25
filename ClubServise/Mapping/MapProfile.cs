﻿using AutoMapper;
using Catalog.DataTransferObjects.Requests;
using Catalog.DataTransferObjects.Responses;
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Club, ClubDisplayResponse>();
            CreateMap<AddClubRequest, Club>();
            CreateMap<UpdateClubRequest, Club>();
        }
        
    }
}
