using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteMVC2.Models
{
    public class MyDebugFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // "OnActionExecuting" samma sak 
            Debug.WriteLine(nameof(MyDebugFilterAttribute.OnActionExecuting));
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("OnActionExecuted");
        }


    }
}
