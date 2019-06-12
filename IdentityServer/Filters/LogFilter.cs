using IdentityServer.Tools.LogMachine;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Filters
{
    public class LogFilter : ActionFilterAttribute
    {
        public ILogMachine _logMachine { get; set; }

        public LogFilter(ILogMachine logMachine)
        {
            _logMachine = logMachine;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logMachine.Log("Request incoming");

            foreach (var item in context.HttpContext.Request.Headers)
            {
                _logMachine.Log("Request header " + item.Key + " : " + item.Value);
            }

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logMachine.Log("Response incoming");
            _logMachine.Log("Headers of response : ");
            foreach (var item in context.HttpContext.Response.Headers)
            {
                _logMachine.Log("Response header " + item.Key + " : " + item.Value);
            }
            _logMachine.Log("End of Headers. ");

            _logMachine.Log("Response's Model State : ");

            foreach (var item in context.ModelState.Keys)
            {
                _logMachine.Log($"Key {item} has value {context.ModelState[item].RawValue}");
            }



            base.OnActionExecuted(context);
        }

    }
}
