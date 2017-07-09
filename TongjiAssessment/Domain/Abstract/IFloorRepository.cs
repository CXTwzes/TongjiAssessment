using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Abstract
{
    public class IFloorRepository
    {
        IEnumerable<Floor> Floors { get; }
    }
}