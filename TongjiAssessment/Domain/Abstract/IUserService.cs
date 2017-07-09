using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TongjiAssessment.Models;

namespace TongjiAssessment.Domain.Abstract
{
    public interface IUserService
    {
        ClaimsIdentity createIdentity(LoginViewModel user, string authenticationType);
    }
}
