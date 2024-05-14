using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TranningCenter.Fillters
{
    public class HandleError : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {

            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Error";


            ContentResult contentResult = new ContentResult();
            contentResult.Content = "sdd";
            context.Result = contentResult;


        }
    }
}
