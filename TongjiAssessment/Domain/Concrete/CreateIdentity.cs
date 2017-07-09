using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNet.Identity;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Models;

namespace TongjiAssessment.Domain.Concrete
{
    public class CreateIdentity : IUserService
    {
        public ClaimsIdentity createIdentity(LoginViewModel user, string authenticationType)
        {
            ClaimsIdentity _identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            _identity.AddClaim(new Claim(ClaimTypes.Name, user.Username));
            _identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Password));
            return _identity;
        }
    }
}