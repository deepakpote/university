using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net;
using university.Repositry.Contract;
using Microsoft.AspNetCore.Mvc.Filters;



namespace university.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValidationController : ControllerBase
    {
                
    }

    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState); 
            }
        }
    }

    public class NotImplExceptionFilterAttribute : ExceptionFilterAttribute 
    {
        public override void OnException(ExceptionContext  context)
        {
            
            if (context.Exception is UnauthorizedAccessException)
            {
                context.HttpContext.Response.StatusCode = 401;
            }
            else
            {
                // Unhandled errors
                #if !DEBUG
                    var msg = "An unhandled error occurred.";                
                    string stack = null;
                #else
                    var msg = context.Exception.GetBaseException().Message;
                    string stack = context.Exception.StackTrace;
                #endif
                
                context.HttpContext.Response.StatusCode = 500;
            }

            base.OnException(context);
        }
    }
}