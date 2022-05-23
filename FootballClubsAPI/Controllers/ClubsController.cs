
using Catalog.Business;
using Catalog.DataTransferObjects.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FootballClubsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IClubServise Servise;

        public ClubsController(IClubServise clubServise)
        {
            Servise = clubServise;
        }

        [HttpGet]
        public async Task<IActionResult> GetClubs()
        {
            var clubs = await Servise.GetClubs();
            return Ok(clubs);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClubById(int id)
        {
            var club = await Servise.GetClubById(id);
            return Ok(club);

        }

        [HttpGet("Search/{Name}")]
        public async Task<IActionResult> GetClubByName(string Name)
        {
            var club = await Servise.GetClubByName(Name);
            return Ok(club);
        }
    }
}
