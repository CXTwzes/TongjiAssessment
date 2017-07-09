using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.HttpHelper;

namespace TongjiAssessment.Domain.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = false;
            if(Helper.isTongjiUser(username, password))
            {
                result = true;
                FormsAuthentication.SetAuthCookie(username, false);
            }
            else
            {
                FormsAuthentication.SetAuthCookie("", true);
            }
           return result;
        }
    }
}