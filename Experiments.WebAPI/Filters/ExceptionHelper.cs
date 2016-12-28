using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace Experiments.WebAPI.Filters
{
    public class ExceptionHelper : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpResponseMessage message = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            message.Content = new StringContent("Message: Alpha");

            actionExecutedContext.Response = message;
        }

        public override Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            HttpResponseMessage message = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            message.Content = new StringContent("Message: Alpha");

            actionExecutedContext.Response = message;
            return base.OnExceptionAsync(actionExecutedContext, cancellationToken);
        }

    }
}