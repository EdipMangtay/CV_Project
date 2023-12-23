using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Project.Models
{
    public class Auth:FilterAttribute,IAuthorizationFilter
    {   

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (CurrentSession.User == null)
            {
                filterContext.Result = new RedirectResult("/Home/Login");

            }
        }
    }
}