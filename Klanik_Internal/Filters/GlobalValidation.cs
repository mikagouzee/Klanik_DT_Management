using Klanik_Internal.LogMachines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Klanik_Internal.Filters {

    public class ValidateModelFilter : ActionFilterAttribute {
        public ILogMachine _logMachine { get; set; }

        public ValidateModelFilter(ILogMachine logger)
        {
            _logMachine = logger;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                if (!context.ModelState.IsValid)
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }
            }
            catch (System.Exception ex)
            {

                _logMachine.Log(ex.Message);
                _logMachine.Log(ex.InnerException?.Message);
            }

        }
    }


}
