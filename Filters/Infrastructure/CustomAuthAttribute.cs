using System.Web.Mvc;
using System.Web;

namespace Filters.Infrastructure
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool lockAllowed;

        public CustomAuthAttribute(bool allowedParam)
        {
            lockAllowed = allowedParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return lockAllowed;
            }
            else
            {
                return true;
            }         
        }
    }
}