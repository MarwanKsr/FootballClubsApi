using Catalog.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballClubsAPI.Filters
{
    public class IsExistsOperation : IAsyncActionFilter
    {
        private readonly IClubServise clubServise;

        public IsExistsOperation(IClubServise clubServise)
        {
            this.clubServise = clubServise;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult("id is required");
            }
            else
            {
                var id = (int)context.ActionArguments["id"];
                if (!await clubServise.IsClubExists(id))
                {
                    context.Result = new NotFoundObjectResult(new { message = $"The club with the id {id} has not been found" });
                }
                else
                {
                    await next.Invoke();
                }
                
            }
        }
    }
}
