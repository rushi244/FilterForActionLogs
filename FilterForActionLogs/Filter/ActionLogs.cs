using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace FilterForActionLogs.Filter
{
    public class ActionLogs:ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Writelogs(string.Format("Action method{0}, is executing at{1}", actionContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Writelogs(string.Format("Action method{0}, is executing at{1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }
        public void Writelogs(string strTxt)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Log/log.txt"), "Web Api logs:"+strTxt + Environment.NewLine);
        }
    }
}