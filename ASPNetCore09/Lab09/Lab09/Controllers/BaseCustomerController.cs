using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab09.Controllers
{
    public class BaseCustomerController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.GetString("AdminLogin") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "LoginCustomer", Action = "Index" }));
            }

            base.OnActionExecuted(context);
        }
    }
}
