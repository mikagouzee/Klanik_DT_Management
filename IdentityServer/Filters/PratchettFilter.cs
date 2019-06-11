using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Filters
{
    public class PratchettFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Clacks-Overhead", "GNU Terry Pratchett");

            base.OnActionExecuted(context);
        }
    }
}
