using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace DellaViaAutomation.Http.Attributes
{
    public class ApiExceptionAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public object HttpResponseMassage { get; private set; }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpResponseMessage httpResponseMassage = new HttpResponseMessage(System.Net.HttpStatusCode.NotImplemented);
            httpResponseMassage.ReasonPhrase = actionExecutedContext.Exception.Message;
            actionExecutedContext.Response = httpResponseMassage;
            base.OnException(actionExecutedContext);
        }
    }
}