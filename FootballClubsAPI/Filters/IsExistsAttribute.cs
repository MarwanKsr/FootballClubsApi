using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballClubsAPI.Filters
{
    public class IsExistsAttribute : TypeFilterAttribute
    {
        public IsExistsAttribute() : base(typeof(IsExistsOperation))
        {

        }
    }
}
