
using Catalog.Business;
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

        /* [HttpGet]
        public async Task<IActionResult> GetClubsWithAllDetails()
        {
            var clubs = await Servise.GetClubsWithAllDetails();
            return Ok(clubs);
        } */

        [HttpGet]
        public async Task<IActionResult> GetClubs()
        {
            var _clubs = await Servise.GetClubs();
            return Ok(_clubs);
        }
        
    }
}
