using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;

namespace Utilites
{
    public class ExceptionLoggerAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext filterContext)
        {
            ExceptionDetail exceptionDetail = new ExceptionDetail()
            {
                ExceptionMessage = filterContext.Exception.Message,
                StackTrace = filterContext.Exception.StackTrace,
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                Date = DateTime.Now
            };

           
            using (LoggerContext db = new LoggerContext(
                new DbContextOptionsBuilder<LoggerContext>()
                .UseSqlite("Data Source=./Data/log.db;")
                .Options))
            {
                db.ExceptionDetails.Add(exceptionDetail);
                db.SaveChanges();
            }

            filterContext.ExceptionHandled = true;
        }

    }
}
